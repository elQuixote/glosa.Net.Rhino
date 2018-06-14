using System.Collections.Generic;
using System.Linq;
using Rhino.Geometry;
using Glosa.Net.Core.Interfaces;
using Glosa.Net.Core.Geometry.Polygon;
using Glosa.Net.Core.Geometry.Path;
using Glosa.Net.Core.Geometry.Vector;

namespace GlosaNet.Rhino.Support
{
    /// <summary>
    /// 
    /// </summary>
    public static class PolygonSupport
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="closed"></param>
        /// <returns></returns>
        public static GlosaPolygon ToGlosaPolygon(Polyline p, bool closed)
        {
            var list = p.ToList();
            IVector[] ivecArray = list.Select(x => (IVector)(PointSupport.ToGlosaVector3(x))).ToArray();
            return new GlosaPolygon(new GlosaPolyline(ivecArray, closed));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        /// <param name="closed"></param>
        /// <returns></returns>
        public static GlosaPolygon ToGlosaPolyline(List<Point3d> points, bool closed)
        {
            IVector[] ivecArray = points.Select(x => (IVector)(PointSupport.ToGlosaVector3(x))).ToArray();
            return new GlosaPolygon(new GlosaPolyline(ivecArray, closed));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gp"></param>
        /// <returns></returns>
        public static Polyline ToPolyline(GlosaPolygon gp)
        {
            switch (gp.polyline.vertices[0].Dimension())
            {
                case 0:
                    throw new System.ArgumentException("Polygon has an unvalid dimension", "dimension");
                case 1:
                    throw new System.ArgumentException("Polygon cannot have GlosaVectors of dimension 1", "dimension");
                case 2:
                    var list = gp.polyline.GetVertices().ToList();
                    List<GlosaVector2> pt2DList = list.Select(x => ((GlosaVector2)x)).ToList();
                    List<Point3d> ptList = pt2DList.Select(x => (PointSupport.ToPoint3d(x.ToVector3()))).ToList();
                    return new Polyline(ptList);
                case 3:
                    list = gp.polyline.GetVertices().ToList();
                    ptList = list.Select(x => (PointSupport.ToPoint3d((GlosaVector3)x))).ToList();
                    return new Polyline(ptList);
                case 4:
                    list = gp.polyline.GetVertices().ToList();
                    List<GlosaVector4> pt4DList = list.Select(x => ((GlosaVector4)x)).ToList();
                    ptList = pt4DList.Select(x => (PointSupport.ToPoint3d(x.ToVector3()))).ToList();
                    return new Polyline(ptList);
                default: throw new System.ArgumentException("Polygon has an unvalid dimension", "dimension");
            }
        }
    }
}
