using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Hunting.Classes;
using SharpDX.Direct2D1;
using System;

namespace Hunting
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private Microsoft.Xna.Framework.Graphics.SpriteBatch _spriteBatch;
        Target target;
        private int screenWidth = 800;
        private int screenHeight = 600;
        HUD hud;
        background bg;
        Timer timer = new Timer();
        GameOver gameOver;
        bool endGame = false;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            target = new Target();
            hud = new HUD();
            bg = new background();
            target.TargetShotEvent += hud.Update;
            timer = new Timer();
            gameOver = new GameOver();
            timer.Start();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new Microsoft.Xna.Framework.Graphics.SpriteBatch(GraphicsDevice);
            target.LoadContent(Content);
            hud.LoadContent(Content);
            bg.LoadContent(Content);
            gameOver.LoadContent(Content);
            timer.LoadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (timer.time == 0)
            {
                endGame = true;
            }
            // TODO: Add your update logic here
            target.Update();
            timer.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            bg.Draw(_spriteBatch);
            if (!endGame)
            {
                target.Draw(_spriteBatch);
                hud.Draw(_spriteBatch);
                timer.Draw(_spriteBatch);
            }
            else
            {
                gameOver.Draw(_spriteBatch, hud.score);
            }
            
            
            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}