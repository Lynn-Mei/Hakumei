using Logic.Generation.Ressources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HMI
{
    /// <summary>
    /// Handles the execution of gamescreens
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private TextureManager _textureManager;
        private SpriteBatchManager _batchManager;
        private GameScreen gameScreen;

        public GameScreen GameScreen { get { return gameScreen; } set { this.GameScreen = value; } }
        /// <summary>
        /// Initialisation of the manager
        /// </summary>
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _batchManager = new SpriteBatchManager();
            TextureManager.Device = this.GraphicsDevice;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Initializes the first gamescreen
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.gameScreen = new GameScreen();
            base.Initialize();
        }

        /// <summary>
        /// Loads content when a new gamescreen is created
        /// </summary>
        protected override void LoadContent()
        {
            SpriteBatchManager.SpriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            this.Content.Dispose();
            foreach(IRessource r in this.GameScreen.Ressources.Get())
            {
                switch (r.Name)
                {
                    case "Sprite":
                        if (r is Sprite customItem) 
                            this._textureManager.AddTexture(this.Content.Load<Texture2D>(customItem.Filename.ToString()));
                        break;
                    case "Custom2dTexture":
                        int[] clr = ((Custom2dTexture)r).Color;
                        Texture2D texture = new Texture2D(GraphicsDevice, 1, 1);
                        texture.SetData(new[] { new Microsoft.Xna.Framework.Color(clr[0], clr[1], clr[2], clr[3]) });
                        break;
                }
                    
            }
        }

        /// <summary>
        /// Handles player interaction with gamescreen
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// Draws the gamescreen every time t
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            this._batchManager.Begin();

            this._batchManager.Draw();

            this._batchManager.End();
            base.Draw(gameTime);
        }
    }
}