using System;
using System.Collections.Generic;

namespace COMS10001_algorithms
{
    public class PointCloud
    {
        private ISet<Tuple<int, int>> _points;
 
        public PointCloud(ISet<Tuple<int, int>> points)
        {
            this._points = points;
        }

        public List<Tuple<int, int>> ConvexHull()
        {
            return null;
        } 
    }
}