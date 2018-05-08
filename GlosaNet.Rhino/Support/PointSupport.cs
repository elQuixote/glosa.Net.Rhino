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

        /// <summary>
        /// Creates a GlosaVector3 from a Rhino Point3d
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point3d</param>
        /// <returns>A new GlosaVector3 with the three, X and Y and Z, components from the Rhino Point3d</returns>
        public static GlosaVector3 ToGlosaVector3(Point3d rhinoPoint)
        {
            return new GlosaVector3(rhinoPoint.X, rhinoPoint.Y, rhinoPoint.Z);
        }

        /// <summary>
        /// Creates a GlosaVector3 from a Rhino Point3f
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point3f</param>
        /// <returns>A new GlosaVector2 with the three, X and Y and Z, components from the Rhino Point3f</returns>
        public static GlosaVector3 ToGlosaVector3(Point3f rhinoVector)
        {
            return new GlosaVector3(rhinoVector.X, rhinoVector.Y, rhinoVector.Z);
        }

        /// <summary>
        /// Creates a Rhino Point3d from a GlosaVector3
        /// </summary>
        /// <param name="glosaVector">The glosaVector3 to convert</param>
        /// <returns>A new Rhino Point3d with the three, X and Y and Z, components from the GlosaVector3</returns>
        public static Point3d ToPoint3d(GlosaVector3 glosaVector)
        {
            return new Point3d(glosaVector.x, glosaVector.y, glosaVector.z);
        }

        /// <summary>
        /// Creates a Rhino Point3f from a GlosaVector3
        /// </summary>
        /// <param name="glosaVector">The glosaVector3 to convert</param>
        /// <returns>A new Rhino Point3f with the three, X and Y and Z, components from the GlosaVector3</returns>
        public static Point3f ToPoint3f(GlosaVector3 glosaVector)
        {
            return new Point3f((float)glosaVector.x, (float)glosaVector.y, (float)glosaVector.z);
        }
    }
}
