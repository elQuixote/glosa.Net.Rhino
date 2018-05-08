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
    /// Represents a static class for GlosaVector and Rhino Point interactions
    /// </summary>
    public static class PointSupport
    {
        /// <summary>
        /// Creates a GlosaVector2 from a Rhino Point2d
        /// </summary>
        /// <param name="rhinoPoint">The Rhino Point2d</param>
        /// <returns>A new GlosaVector2 with the two, X and Y, components from the Rhino Point2d</returns>
        public static GlosaVector2 ToGlosaVector2(Point2d rhinoPoint)
        {
            return new GlosaVector2(rhinoPoint.X, rhinoPoint.Y);
        }

        /// <summary>
        /// Creates a GlosaVector2 from a Rhino Point2f
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point2f</param>
        /// <returns>A new GlosaVector2 with the two, X and Y, components from the Rhino Point2f</returns>
        public static GlosaVector2 ToGlosaVector2(Point2f rhinoPoint)
        {
            return new GlosaVector2(rhinoPoint.X, rhinoPoint.Y);
        }

        /// <summary>
        /// Creates a Rhino Point2d from a GlosaVector2
        /// </summary>
        /// <param name="glosaVector">The glosaVector2 to convert</param>
        /// <returns>A new Rhino Point2d with the two, X and Y, components from the GlosaVector2</returns>
        public static Point2d ToPoint2d(GlosaVector2 glosaVector)
        {
            return new Point2d(glosaVector.x, glosaVector.y);
        }

        /// <summary>
        /// Creates a Rhino Point2f from a GlosaVector2
        /// </summary>
        /// <param name="glosaVector">The glosaVector2 to convert</param>
        /// <returns>A new Rhino Point2f with the two, X and Y, components from the GlosaVector2</returns>
        public static Point2f ToPoint2f(GlosaVector2 glosaVector)
        {
            Point2f rv = new Point2f();
            rv.X = (float)glosaVector.x;
            rv.Y = (float)glosaVector.y;
            return rv;
        }
    }
}
