using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public class PolygonContainer
    {
        private List<int> Vertexes = new List<int>();
        private List<int> StartIndex = new List<int>() { 0 };
        public int Count => StartIndex.Count - 1;
        public int VertexInPolygonCount(int index) => StartIndex[index + 1] - StartIndex[index];
        public int this[int PolygonIndex, int VertexIndex]
        {
            get
            {
                if (VertexIndex >= VertexInPolygonCount(PolygonIndex) || VertexIndex < 0)
                    throw new IndexOutOfRangeException();
                return Vertexes[StartIndex[PolygonIndex] + VertexIndex];
            }
            set
            {
                if (VertexIndex < VertexInPolygonCount(PolygonIndex))
                    throw new IndexOutOfRangeException();
                Vertexes[StartIndex[PolygonIndex] + VertexIndex] = value;
            }
        }
        public void Add(List<int> Polygon)
        {
            Vertexes.AddRange(Polygon);
            StartIndex.Add(Vertexes.Count);
        }
    }
}
