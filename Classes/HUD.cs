using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Hunting.Classes;

namespace Hunting.Classes
{
    internal class HUD
    {
        private Label labelScore;
        public int score;
        
        public HUD()
        {
            Vector2 position = new Vector2(20, 20);

           

            labelScore = new Label("Score: " + score,
                new Vector2(position.X, position.Y),
                Color.White);
        }

        public void LoadContent(ContentManager content)
        {
          
            labelScore.LoadContent(content);
        }

        public void Update()
        {
            score += 1;
            labelScore.SetText("Score: " + score.ToString());
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            labelScore.Draw(spriteBatch);
        }
    }
}
