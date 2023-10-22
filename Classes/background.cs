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

namespace Hunting.Classes
{
    internal class background
    {
        public Vector2 frontposition1;
        
        public Texture2D fronttexture;
        
        public background()
        {
            fronttexture = null;
            frontposition1 = Vector2.Zero;
            
        }
        public void LoadContent(ContentManager content)
        {
            fronttexture = content.Load<Texture2D>("back");
            
        }
        public void Update()
        {
            

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(fronttexture, frontposition1, Color.White);

        }
    }
}
