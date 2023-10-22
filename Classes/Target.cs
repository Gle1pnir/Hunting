using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Hunting.Classes
{   
    internal class Target
    {
        private Vector2 position;
        private Texture2D texture;
        private Rectangle rectangle;
        public event Action TargetShotEvent;
        
        public Target()
        {
            position = new Vector2(200, 200);
            texture = null;
        }
        public void LoadContent(ContentManager manager)
        {
            texture = manager.Load<Texture2D>("target");
            rectangle = new Rectangle((int)position.X, (int)position.Y, 50, 50);
        }
        public void Update()
        {
            if (rectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Random random = new Random();
                position.X = random.Next(70, 700);
                position.Y = random.Next(70, 500);
                TargetShotEvent();
            }
            rectangle = new Rectangle((int)position.X, (int)position.Y, 50, 50);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
