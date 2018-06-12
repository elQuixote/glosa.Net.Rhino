using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glosa.Net.Core.Geometry;
using Rhino.Geometry;
using Glosa.Net.Core.Interfaces;

namespace GlosaNet.Rhino.Support
{
    /// <summary>
    /// 
    /// </summary>
    public static class PolylineSupport
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="closed"></param>
        /// <returns></returns>
        public static GlosaPolyline ToGlosaPolyline(Polyline p, bool closed)
        {
            var list = p.ToList();
            IVector[] ivecArray = list.Select(x => (IVector)(PointSupport.ToGlosaVector3(x))).ToArray();
            return new GlosaPolyline(ivecArray, closed);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        /// <param name="closed"></param>
        /// <returns></returns>
        public static GlosaPolyline ToGlosaPolyline(List<Point3d> points, bool closed)
        {
            IVector[] ivecArray = points.Select(x => (IVector)(PointSupport.ToGlosaVector3(x))).ToArray();
            return new GlosaPolyline(ivecArray, closed);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="segments"></param>
        /// <returns></returns>
        public static GlosaPolyline ToGlosaPolyline(List<Line> segments)
        {
            GlosaLineSegment[] segmentsArray = segments.Select(x => (LineSegmentSupport.ToGlosaLineSegment(x))).ToArray();
            return new GlosaPolyline(segmentsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gp"></param>
        /// <returns></returns>
        public static Polyline ToPolyline(GlosaPolyline gp)
        {
            switch (gp.vertices[0].Dimension())
            {
                case 0:
                    throw new System.ArgumentException("Polyline has an unvalid dimension", "dimension");
                case 1:
                    throw new System.ArgumentException("Polyline cannot have GlosaVectors of dimension 1", "dimension");
                case 2:
                    var list = gp.GetVertices().ToList();
                    List<GlosaVector2> pt2DList = list.Select(x => ((GlosaVector2)x)).ToList();
                    List<Point3d> ptList = pt2DList.Select(x => (PointSupport.ToPoint3d(x.ToVector3()))).ToList();
                    return new Polyline(ptList);
                case 3:
                    list = gp.GetVertices().ToList();
                    ptList = list.Select(x => (PointSupport.ToPoint3d((GlosaVector3)x))).ToList();
                    return new Polyline(ptList);
                case 4:
                    list = gp.GetVertices().ToList();
                    List<GlosaVector4> pt4DList = list.Select(x => ((GlosaVector4)x)).ToList();
                    ptList = pt4DList.Select(x => (PointSupport.ToPoint3d(x.ToVector3()))).ToList();
                    return new Polyline(ptList);
                default: throw new System.ArgumentException("Polyline has an unvalid dimension", "dimension");
            }
        }
    }
}
