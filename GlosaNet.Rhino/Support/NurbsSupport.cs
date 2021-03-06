﻿using System.Collections.Generic;
using System.Linq;
using Glosa.Net.Core.Geometry.Path;
using Rhino.Geometry;
using Glosa.Net.Core.Interfaces;
using Glosa.Net.Core.Geometry;

namespace GlosaNet.Rhino.Support
{
    public static class NurbsSupport
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nurbsCurve"></param>
        /// <returns></returns>
        public static GlosaNurbsCurve ToGlosaNurbsCurve(NurbsCurve nurbsCurve)
        {
            List<ControlPoint> controlPoints = nurbsCurve.Points.ToList();
            IVector[] ivecArray = controlPoints.Select(x => (IVector)(PointSupport.ToGlosaVector3(x.Location))).ToArray();
            double[] weights = controlPoints.Select(x => (x.Weight)).ToArray();
            double[] knots = nurbsCurve.Knots.ToArray();
            return new GlosaNurbsCurve(ivecArray, weights, knots, nurbsCurve.Degree);          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="glosaNurbsCurve"></param>
        /// <returns></returns>
        public static NurbsCurve ToNurbsCurve(GlosaNurbsCurve glosaNurbsCurve)
        {
            var list = glosaNurbsCurve.controlPoints.ToList();
            List<GlosaVector3> pt3DList = list.Select(x => ((GlosaVector3)x)).ToList();
            List<Point3d> ptList = pt3DList.Select(x => (PointSupport.ToPoint3d(x))).ToList();

            NurbsCurve nc = new NurbsCurve(glosaNurbsCurve.degree, glosaNurbsCurve.controlPoints.Length);
            int count = 0;
            foreach(double d in nc.Knots)
            {
                nc.Points.SetPoint(count, ptList[count].X, ptList[count].Y, ptList[count].Z, glosaNurbsCurve.weights[count]);
                nc.Knots[count] = glosaNurbsCurve.knots[count];
                count++;
            }
            return nc;
        }
    }
}
