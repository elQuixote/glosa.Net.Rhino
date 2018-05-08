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
    }
}
