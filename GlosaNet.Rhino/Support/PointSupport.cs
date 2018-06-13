using Glosa.Net.Core.Geometry;
using Rhino.Geometry;

namespace GlosaNet.Rhino.Support
{
    /// <summary>
    /// Represents a static class for GlosaVector and Rhino Point interactions
    /// </summary>
    public static class PointSupport
    {
        #region Vector2
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
        #endregion
        #region Vector3
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
        #endregion
        #region Vector4
        /// <summary>
        /// Creates a GlosaVector4 from a Rhino Point3d and user defined W component
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point3d</param>
        /// <param name="w">The w value</param>
        /// <returns>A new GlosaVector4 with the three, X and Y and Z, components from the Rhino Point3d and user defined W</returns>
        public static GlosaVector4 ToGlosaVector4(Point3d rhinoPoint, double w)
        {
            return new GlosaVector4(rhinoPoint.X, rhinoPoint.Y, rhinoPoint.Z, w);
        }

        /// <summary>
        /// Creates a GlosaVector4 from a Rhino Point3f and user defined W component
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point3f</param>
        /// <param name="w">The w value</param>
        /// <returns>A new GlosaVector4 with the three, X and Y and Z, components from the Rhino Point3f and user defined W</returns>
        public static GlosaVector4 ToGlosaVector4(Point3f rhinoVector, double w)
        {
            return new GlosaVector4(rhinoVector.X, rhinoVector.Y, rhinoVector.Z, w);
        }

        /// <summary>
        /// Creates a GlosaVector4 from a Rhino Point2d and user defined Z and W component
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point2d</param>
        /// <param name="z">The z value</param>
        /// <param name="w">The w value</param>
        /// <returns>A new GlosaVector4 with the two, X and Y, components from the Rhino Point3d and user defined Z and W</returns>
        public static GlosaVector4 ToGlosaVector4(Point2d rhinoPoint, double z, double w)
        {
            return new GlosaVector4(rhinoPoint.X, rhinoPoint.Y, z, w);
        }

        /// <summary>
        /// Creates a GlosaVector4 from a Rhino Point2f and user defined Z and W component
        /// </summary>
        /// <param name="rhinoVector">The Rhino Point2f</param>
        /// <param name="z">The z value</param>
        /// <param name="w">The w value</param>
        /// <returns>A new GlosaVector4 with the two, X and Y, components from the Rhino Point3f and user defined Z and W</returns>
        public static GlosaVector4 ToGlosaVector4(Point2f rhinoVector, double z, double w)
        {
            return new GlosaVector4(rhinoVector.X, rhinoVector.Y, z, w);
        }

        /// <summary>
        /// Creates a Rhino Point3d from a GlosaVector4
        /// </summary>
        /// <param name="glosaVector">The glosaVector4 to convert</param>
        /// <returns>A new Rhino Point3d with the three, X and Y and Z, components from the GlosaVector4</returns>
        public static Point3d ToPoint3d(GlosaVector4 glosaVector)
        {
            return new Point3d(glosaVector.x, glosaVector.y, glosaVector.z);
        }

        /// <summary>
        /// Creates a Rhino Point3f from a GlosaVector4
        /// </summary>
        /// <param name="glosaVector">The glosaVector4 to convert</param>
        /// <returns>A new Rhino Point3f with the three, X and Y and Z, components from the GlosaVector4</returns>
        public static Point3f ToPoint3f(GlosaVector4 glosaVector)
        {
            return new Point3f((float)glosaVector.x, (float)glosaVector.y, (float)glosaVector.z);
        }
        #endregion
    }
}
