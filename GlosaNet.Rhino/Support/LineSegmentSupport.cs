using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glosa.Net.Core.Geometry;
using Rhino.Geometry;

namespace GlosaNet.Rhino.Support
{
    public static class LineSegmentSupport
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static GlosaLineSegment ToGlosaLineSegment(Line l)
        {
            return new GlosaLineSegment(PointSupport.ToGlosaVector3(l.PointAt(0)), PointSupport.ToGlosaVector3(l.PointAt(1)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static GlosaLineSegment ToGlosaLineSegment(Vector3d start, Vector3d end)
        {
            return new GlosaLineSegment(VectorSupport.ToGlosaVector3(start), VectorSupport.ToGlosaVector3(end));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static GlosaLineSegment ToGlosaLineSegment(Vector2d start, Vector2d end)
        {
            return new GlosaLineSegment(VectorSupport.ToGlosaVector2(start), VectorSupport.ToGlosaVector2(end));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static GlosaLineSegment ToGlosaLineSegment(Point3d start, Point3d end)
        {
            return new GlosaLineSegment(PointSupport.ToGlosaVector3(start), PointSupport.ToGlosaVector3(end));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public static Line ToLine(GlosaLineSegment gl)
        {
            switch (gl.startVertex.Dimension())
            {
                case 0:
                    throw new System.ArgumentException("LineSegment has an unvalid dimension", "dimension");
                case 1:
                    throw new System.ArgumentException("LineSegment cannot have GlosaVectors of dimension 1", "dimension");
                case 2:
                    GlosaVector2 start = (GlosaVector2)gl.startVertex;
                    GlosaVector2 end = (GlosaVector2)gl.endVertex;
                    return new Line(PointSupport.ToPoint3d(start.ToVector3()), PointSupport.ToPoint3d(end.ToVector3()));
                case 3:
                    GlosaVector3 start3 = (GlosaVector3)gl.startVertex;
                    GlosaVector3 end3 = (GlosaVector3)gl.endVertex;
                    return new Line(PointSupport.ToPoint3d(start3), PointSupport.ToPoint3d(end3));
                case 4:
                    GlosaVector4 start4 = (GlosaVector4)gl.startVertex;
                    GlosaVector4 end4 = (GlosaVector4)gl.endVertex;
                    return new Line(PointSupport.ToPoint3d(start4.ToVector3()), PointSupport.ToPoint3d(end4.ToVector3()));
                default: throw new System.ArgumentException("LineSegment has an unvalid dimension", "dimension");
            }
        }
    }
}
