using System;
using System.Collections.Generic;
using System.Text;

namespace Chimera.Physics.Farseer.FarseerGames.FarseerXNAPhysics.Dynamics {
    internal class SpringList : List<Spring> {
        internal static bool IsDisposed(Spring spring) {
            //if either of the joint's connected bodies are disposed then dispose the joint.
            if (spring.Body2 == null) {
                if (spring.Body1.IsDisposed) {
                    spring.Dispose();
                }
            }
            else {
                if (spring.Body1.IsDisposed || spring.Body2.IsDisposed) {
                    spring.Dispose();
                }
            }

            return spring.IsDisposed;
        }
    }
}
