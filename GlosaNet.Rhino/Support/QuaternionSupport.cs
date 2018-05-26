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
    /// Represents a static class for GlosaQuaternion and Rhino Quaternion interactions
    /// </summary>
    public static class QuaternionSupport
    {
        /// <summary>
        /// Creates a GlosaQuaternion from a Rhino Quaternion
        /// </summary>
        /// <param name="q">The Rhino Quaternion</param>
        /// <returns>A new GlosaQuaternion</returns>
        public static GlosaQuaternion ToGlosaQuaternion(Quaternion q)
        {
            return new GlosaQuaternion(q.A, q.B, q.C, q.D);
        }

        /// <summary>
        /// Creates a Rhino Quaternion from a GlosaQuaternion
        /// </summary>
        /// <param name="q">The GlosaQuaternion</param>
        /// <returns>A new Rhino Quaternion</returns>
        public static Quaternion ToRhinoQuaternion(GlosaQuaternion q)
        {
            return new Quaternion(q.x, q.y, q.z, q.w);
        }

        /// <summary>
        /// Creates a GlosaQuaternion from a Rhino Vector3d and a W value
        /// </summary>
        /// <param name="vector">The 3d vector</param>
        /// <param name="w">The W value</param>
        /// <returns>A new GlosaQuaternion from a Rhino Vector3d and a user defined W value</returns>
        public static GlosaQuaternion ToGlosaQuaternion(Vector3d vector, double w)
        {
            return new GlosaQuaternion(vector.X, vector.Y, vector.Z, w);
        }

        /// <summary>
        /// Creates a GlosaQuaternion from a Rhino Vector3f and a W value
        /// </summary>
        /// <param name="vector">The 3f vector</param>
        /// <param name="w">The W value</param>
        /// <returns>A new GlosaQuaternion from a Rhino Vector3f and a user defined W value</returns>
        public static GlosaQuaternion ToGlosaQuaternion(Vector3f vector, double w)
        {
            return new GlosaQuaternion(vector.X, vector.Y, vector.Z, w);
        }

        /// <summary>
        /// Creates a GlosaQuaternion from a Rhino Vector2d and a Z and W value
        /// </summary>
        /// <param name="vector">The 2d vector</param>
        /// <param name="z">The Z value</param>
        /// <param name="w">The W value</param>
        /// <returns>A new GlosaQuaternion from a Rhino Vector2d and a user defined Z and W values</returns>
        public static GlosaQuaternion ToGlosaQuaternion(Vector2d vector, double z, double w)
        {
            return new GlosaQuaternion(vector.X, vector.Y, z, w);
        }

        /// <summary>
        /// Creates a GlosaQuaternion from a Rhino Vector2f and a Z and W value
        /// </summary>
        /// <param name="vector">The 2f vector</param>
        /// <param name="z">The Z value</param>
        /// <param name="w">The W value</param>
        /// <returns>A new GlosaQuaternion from a Rhino Vector2f and a user defined Z and W values</returns>
        public static GlosaQuaternion ToGlosaQuaternion(Vector2f vector, double z, double w)
        {
            return new GlosaQuaternion(vector.X, vector.Y, z, w);
        }

        /// <summary>
        /// Creates a RhinoQuaternion from a GlosaVector2 and a Z and W value
        /// </summary>
        /// <param name="vector">The GlosaVector2</param>
        /// <param name="z">The Z value</param>
        /// <param name="w">The W value</param>
        /// <returns>A new RhinoQuaternion from a GlosaVector2 and a user defined Z and W values</returns>
        public static Quaternion ToRhinoQuaternion(GlosaVector2 vector, double z, double w)
        {
            return new Quaternion(vector.x, vector.y, z, w);
        }

        /// <summary>
        /// Creates a RhinoQuaternion from a GlosaVector3 and a W value
        /// </summary>
        /// <param name="vector">The GlosaVector3</param>
        /// <param name="w">The W value</param>
        /// <returns>A new RhinoQuaternion from a GlosaVector3 and a user defined W value</returns>
        public static Quaternion ToRhinoQuaternion(GlosaVector3 vector, double w)
        {
            return new Quaternion(vector.x, vector.y, vector.z, w);
        }

        /// <summary>
        /// Creates a RhinoQuaternion from a GlosaVector4
        /// </summary>
        /// <param name="vector">The GlosaVector4</param>
        /// <returns>A new RhinoQuaternion from a GlosaVector4</returns>
        public static Quaternion ToRhinoQuaternion(GlosaVector4 vector)
        {
            return new Quaternion(vector.x, vector.y, vector.z, vector.w);
        }
    }
}
