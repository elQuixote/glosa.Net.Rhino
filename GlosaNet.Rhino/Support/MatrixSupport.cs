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
    /// Represents a static class for GlosaMatrix and Rhino Matrix/Transform interactions
    /// </summary>
    public static class MatrixSupport
    {
        /// <summary>
        /// Creates a GlosaMatrix44 from a Rhino Transform
        /// </summary>
        /// <param name="transform">The transform to convert</param>
        /// <returns>The GlosaMatrix 44</returns>
        public static GlosaMatrix44 ToGlosaMatrix44(Transform transform)
        {
            return new GlosaMatrix44(
                transform.M00, transform.M01, transform.M02, transform.M03,
                transform.M10, transform.M11, transform.M12, transform.M13,
                transform.M20, transform.M21, transform.M22, transform.M23,
                transform.M30, transform.M31, transform.M32, transform.M33);
        }

        /// <summary>
        /// Creates a Rhino Transform from a GlosaMatrix44
        /// </summary>
        /// <param name="matrix">The GlosaMatrix44 to convert</param>
        /// <returns>The Rhino Transform</returns>
        public static Transform ToTransform(GlosaMatrix44 matrix)
        {
            Transform transform = new Transform();
            transform.M00 = matrix.m00;
            transform.M01 = matrix.m01;
            transform.M02 = matrix.m02;
            transform.M03 = matrix.m03;

            transform.M10 = matrix.m10;
            transform.M11 = matrix.m11;
            transform.M12 = matrix.m12;
            transform.M13 = matrix.m13;

            transform.M20 = matrix.m20;
            transform.M21 = matrix.m21;
            transform.M22 = matrix.m22;
            transform.M23 = matrix.m23;

            transform.M30 = matrix.m30;
            transform.M31 = matrix.m31;
            transform.M32 = matrix.m32;
            transform.M33 = matrix.m33;
            return transform;
        }
    }
}
