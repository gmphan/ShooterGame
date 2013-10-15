// Projectile.cs
//Using declarations
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Shooter
{
    class Projectile : ShooterGameComponent
    {
        

        // The amount of damage the projectile can inflict to an enemy
        public int Damage;

        // Represents the viewable boundary of the game
        Viewport viewport;

       

        // Determines how fast the projectile moves
        float projectileMoveSpeed;
                
        public Projectile(Game game) : base(game) { }
        public Projectile(Game game, String path) : base(game, path) { }


        public void Initialize(Viewport viewport, Vector2 position)
        {
            base.Initialize(position);
            this.viewport = viewport;          

            Damage = 2;

            projectileMoveSpeed = 20f;
        }

        public void Update()
        {
            // Projectiles always move to the right
            Position.X += projectileMoveSpeed;

            // Deactivate the bullet if it goes out of screen
            if (Position.X + Texture.Width / 2 > viewport.Width)
                Active = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f,
            new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
        }
    }
}
