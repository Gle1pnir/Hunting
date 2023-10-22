using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Hunting.Classes;
using System.Reflection.Metadata;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Hunting.Classes
{
    internal class GameOver
    {
        private Vector2 position = new Vector2(350, 300);
        int score;
        public Label labelScore;
        
        public GameOver()
        {
            labelScore = new Label("Your score: " + score,
                 new Vector2(position.X, position.Y),
                 Color.White);
        }

        public void LoadContent(ContentManager manager)
        {

            labelScore.LoadContent(manager);
        }

        public void Update()
        {
            
            
        }

        public void Draw(SpriteBatch spriteBatch, int score)
        {
            this.score = score;
            labelScore.SetText("Your score: " + score.ToString());
            labelScore.Draw(spriteBatch);

        }
    }
}
