using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheOldTimeSlalomProject
{
    public class Movement : Sprites
    {
        private Vector2 _position;
        private MouseState state;

        public Movement(Texture2D texture)
            : base(texture)
        {
            _position.X = state.X;
            _position.Y = state.Y;
        }

        public void MoveSprite(Sprites sprite)
        {
            if (state.LeftButton == ButtonState.Pressed)
            {
                _position.Y += 1;
            }
        }

        

    }
}
