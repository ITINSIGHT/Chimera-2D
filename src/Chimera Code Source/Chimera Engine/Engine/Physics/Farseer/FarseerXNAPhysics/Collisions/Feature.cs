using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;

using Chimera.Physics.Farseer.FarseerGames.FarseerXNAPhysics.Mathematics;

namespace Chimera.Physics.Farseer.FarseerGames.FarseerXNAPhysics.Collisions {
    public struct Feature {
        public Feature(Vector2 position) {
            Position = position;
            Normal = new Vector2(0,0);
            Distance = Single.MaxValue; 
        }

        public Vector2 Position;
        public Vector2 Normal;
        public float Distance;
    }
}
