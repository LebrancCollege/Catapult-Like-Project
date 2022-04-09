﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CataParuto
{
    public class CataParuto : Game
    {
        public const int SCREEN_WIDTH = 800;
        public const int SCREEN_HEIGHT = 600;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D _cat;
        Vector2 _catPos;

        int speed;

        KeyboardState _currentKey;

        public CataParuto()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            _graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _cat = Content.Load<Texture2D>("visual/sprite/Cat_01");
            _catPos = new Vector2(100, 100);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _currentKey = Keyboard.GetState();
            speed = 3;

            if(_currentKey.IsKeyDown(Keys.Right))
            {
                _catPos.X += speed;   
            }
            if(_currentKey.IsKeyDown(Keys.Left))
            {
                _catPos.X -= speed;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Drawing
            _spriteBatch.Draw(_cat, _catPos, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
