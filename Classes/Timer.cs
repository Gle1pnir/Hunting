using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct3D9;
using System.Threading;
using Hunting.Classes;
using System.Reflection.Metadata;

namespace Hunting.Classes
{
    internal class Timer
    {
        private Vector2 position = new Vector2(600, 20);
        public int time = 30;
        public Label labelTime;
        public Timer()
        {
            labelTime = new Label("Time left: " + time,
                new Vector2(position.X, position.Y),
                Color.White);
        }
        public void LoadContent(ContentManager manager)
        {
            labelTime.LoadContent(manager);
        }

        public void Start()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    time--;
                }

            });
            thread.Start();
        }

        public void Update()
        {
            labelTime.SetText("Time left: " + time.ToString());
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            labelTime.Draw(spriteBatch);
        }
    }
}
