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
    public class Sprites
    {
        private readonly Texture2D _texture;
        private Vector2 _position;
        private Vector2 _velocity;
        public Color Colour = Color.White;
        private float _speed;
        private MouseState state;

        public Sprites(Texture2D texture)
        {
            _texture = texture;
            _position.X = state.X;
            _position.Y = state.Y;
        }


        public virtual void Update(GameTime gameTime, List<Sprites> sprites)
        {
            if (state.LeftButton == ButtonState.Pressed)
            {
                _position.X += 1;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Vector2(Mouse.GetState().X, Mouse.GetState().Y), Color.White);
        }

        #region Collision

        public bool TouchingBlueGate(Sprites sprite)
        {
            return true;
        }

        public bool TouchingRedGate(Sprites sprite)
        {
            return true;
        }

        public bool TouchingRight(Sprites sprite)
        {
            return true;
        }

        public bool TouchingLeft(Sprites sprite)
        {
            return true;
        }

        #endregion
    }
}
