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
        /// Creates a GlosaMatrix33 from a Rhino Matrix
        /// </summary>
        /// <param name="matrix">The Rhino Matrix</param>
        /// <returns>The GlosaMatrix33</returns>
        public static GlosaMatrix33 ToGlosaMatrix33(Matrix matrix)
        {
            if(matrix.RowCount != 3 || matrix.ColumnCount != 3)
            {
                throw new System.ArgumentException("Matrix needs to be squared and 3x3 to convert to GlosaMatrix33", "matrix");
            }
            return new GlosaMatrix33(
                matrix[0,0], matrix[0, 1], matrix[0, 2],
                matrix[1,0], matrix[1, 1], matrix[1, 2],
                matrix[2,0], matrix[2, 1], matrix[2, 2]);
        }

        /// <summary>
        /// Creates a Rhino Matrix from a GlosaMatrix33
        /// </summary>
        /// <param name="matrix">The GlosaMatrix33</param>
        /// <returns>The Rhino 3x3 Matrix</returns>
        public static Matrix ToRhinoMatrix(GlosaMatrix33 matrix)
        {
            Matrix rhinoMatrix = new Matrix(3, 3);
            rhinoMatrix[0, 0] = matrix.m00;
            rhinoMatrix[0, 1] = matrix.m01;
            rhinoMatrix[0, 2] = matrix.m02;

            rhinoMatrix[1, 0] = matrix.m10;
            rhinoMatrix[1, 1] = matrix.m11;
            rhinoMatrix[1, 2] = matrix.m12;

            rhinoMatrix[2, 0] = matrix.m20;
            rhinoMatrix[2, 1] = matrix.m21;
            rhinoMatrix[2, 2] = matrix.m22;
            return rhinoMatrix;
        }

        /// <summary>
        /// Creates a GlosaMatrix33 from a Rhino Matrix
        /// </summary>
        /// <param name="matrix">The Rhino Matrix</param>
        /// <returns>The GlosaMatrix33</returns>
        public static GlosaMatrix44 ToGlosaMatrix44(Matrix matrix)
        {
            if (matrix.RowCount != 4 || matrix.ColumnCount != 4)
            {
                throw new System.ArgumentException("Matrix needs to be squared and 4x4 to convert to GlosaMatrix44", "matrix");
            }
            return new GlosaMatrix44(
                matrix[0, 0], matrix[0, 1], matrix[0, 2], matrix[0, 3],
                matrix[1, 0], matrix[1, 1], matrix[1, 2], matrix[1, 3],
                matrix[2, 0], matrix[2, 1], matrix[2, 2], matrix[2, 3],
                matrix[3, 0], matrix[3, 1], matrix[3, 2], matrix[3, 3]);
        }

        /// <summary>
        /// Creates a Rhino Matrix from a GlosaMatrix44
        /// </summary>
        /// <param name="matrix">The GlosaMatrix44</param>
        /// <returns>The Rhino 4x4 Matrix</returns>
        public static Matrix ToRhinoMatrix(GlosaMatrix44 matrix)
        {
            Matrix rhinoMatrix = new Matrix(4, 4);
            rhinoMatrix[0, 0] = matrix.m00;
            rhinoMatrix[0, 1] = matrix.m01;
            rhinoMatrix[0, 2] = matrix.m02;
            rhinoMatrix[0, 3] = matrix.m03;

            rhinoMatrix[1, 0] = matrix.m10;
            rhinoMatrix[1, 1] = matrix.m11;
            rhinoMatrix[1, 2] = matrix.m12;
            rhinoMatrix[1, 3] = matrix.m13;

            rhinoMatrix[2, 0] = matrix.m20;
            rhinoMatrix[2, 1] = matrix.m21;
            rhinoMatrix[2, 2] = matrix.m22;
            rhinoMatrix[2, 3] = matrix.m23;

            rhinoMatrix[3, 0] = matrix.m30;
            rhinoMatrix[3, 1] = matrix.m31;
            rhinoMatrix[3, 2] = matrix.m32;
            rhinoMatrix[3, 3] = matrix.m33;
            return rhinoMatrix;
        }

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
