using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glosa.Net.Core.Geometry;
using Rhino.Geometry;

namespace GlosaNet.Rhino.Support
{
    /// <summary>
    /// Represents a static class for GlosaVector and Rhino Vector interactions
    /// </summary>
    public static class VectorSupport
    {
        /// <summary>
        /// Creates a GlosaVector2 from a Rhino Vector2d
        /// </summary>
        /// <param name="rhinoVector">The Rhino Vector2d</param>
        /// <returns>A new GlosaVector2 with the two, X and Y, components from the Rhino Vector2d</returns>
        public static GlosaVector2 ToGlosaVector2(Vector2d rhinoVector)
        {
            return new GlosaVector2(rhinoVector.X, rhinoVector.Y);
        }

        /// <summary>
        /// Creates a GlosaVector2 from a Rhino Vector2f
        /// </summary>
        /// <param name="rhinoVector">The Rhino Vector2f</param>
        /// <returns>A new GlosaVector2 with the two, X and Y, components from the Rhino Vector2f</returns>
        public static GlosaVector2 ToGlosaVector2(Vector2f rhinoVector)
        {
            return new GlosaVector2(rhinoVector.X, rhinoVector.Y);
        }

        /// <summary>
        /// Creates a RhinoVector2d from a GlosaVector2
        /// </summary>
        /// <param name="glosaVector">The glosaVector2 to convert</param>
        /// <returns>A new Rhino Vector2d with the two, X and Y, components from the GlosaVector2</returns>
        public static Vector2d ToVector2d(GlosaVector2 glosaVector)
        {
            return new Vector2d(glosaVector.x, glosaVector.y);
        }

        /// <summary>
        /// Creates a RhinoVector2f from a GlosaVector2
        /// </summary>
        /// <param name="glosaVector">The glosaVector2 to convert</param>
        /// <returns>A new Rhino Vector2f with the two, X and Y, components from the GlosaVector2</returns>
        public static Vector2f ToVector2f(GlosaVector2 glosaVector)
        {
            Vector2f rv = new Vector2f();
            rv.X = (float)glosaVector.x;
            rv.Y = (float)glosaVector.y;
            return rv;
        }

        /// <summary>
        /// Creates a GlosaVector3 from a Rhino Vector3d
        /// </summary>
        /// <param name="rhinoVector">The Rhino Vector3d</param>
        /// <returns>A new GlosaVector3 with the three, X and Y and Z, components from the Rhino Vector3d</returns>
        public static GlosaVector3 ToGlosaVector3(Vector3d rhinoVector)
        {
            return new GlosaVector3(rhinoVector.X, rhinoVector.Y, rhinoVector.Z);
        }

        /// <summary>
        /// Creates a GlosaVector3 from a Rhino Vector3f
        /// </summary>
        /// <param name="rhinoVector">The Rhino Vector3f</param>
        /// <returns>A new GlosaVector2 with the three, X and Y and Z, components from the Rhino Vector3f</returns>
        public static GlosaVector3 ToGlosaVector3(Vector3f rhinoVector)
        {
            return new GlosaVector3(rhinoVector.X, rhinoVector.Y, rhinoVector.Z);
        }

        /// <summary>
        /// Creates a RhinoVector3d from a GlosaVector3
        /// </summary>
        /// <param name="glosaVector">The glosaVector3 to convert</param>
        /// <returns>A new Rhino Vector3d with the three, X and Y and Z, components from the GlosaVector3</returns>
        public static Vector3d ToVector3d(GlosaVector3 glosaVector)
        {
            return new Vector3d(glosaVector.x, glosaVector.y, glosaVector.z);
        }

        /// <summary>
        /// Creates a RhinoVector3f from a GlosaVector3
        /// </summary>
        /// <param name="glosaVector">The glosaVector3 to convert</param>
        /// <returns>A new Rhino Vector3f with the three, X and Y and Z, components from the GlosaVector3</returns>
        public static Vector3f ToVector3f(GlosaVector3 glosaVector)
        {
            Vector3f rv = new Vector3f();
            rv.X = (float)glosaVector.x;
            rv.Y = (float)glosaVector.y;
            rv.Z = (float)glosaVector.z;
            return rv;
        }
    }
}
