using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Shooter
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class ShooterGameComponent : Microsoft.Xna.Framework.DrawableGameComponent
    {
        // Image representing the Projectile
        public Texture2D Texture;

        // Position of the Projectile relative to the upper left side of the screen
        public Vector2 Position;

        // State of the Projectile
        public bool Active;

        String contentPath;

        // Get the width of the projectile ship
        public int Width
        {
            get { return Texture.Width; }
        }

        // Get the height of the projectile ship
        public int Height
        {
            get { return Texture.Height; }
        }

        public ShooterGameComponent(Game game)
            : base(game)
        {
            // TODO: Construct any child components here

        }
        public ShooterGameComponent(Game game, string path) : base(game)
        {
            contentPath = path;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public void Initialize(Vector2 position)
        {
            
            Position = position;
            Active = true;
            base.Initialize();
        }
        protected override void LoadContent()
        {
            Texture = Game.Content.Load<Texture2D>(contentPath);
            base.LoadContent();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
    }
}
