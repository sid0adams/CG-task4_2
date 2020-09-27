using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lib3D
{
    public class Scene
    {
        public List<Model> Models { get; private set; }
        public Scene()
        {
            Models = new List<Model>();
        }
        public Bitmap Draw(Camera camera, Screen screen)
        {
            Bitmap image = new Bitmap(screen.Size.Width, screen.Size.Height);
            Graphics g = Graphics.FromImage(image);
            foreach (var model in Models)
            {
                List<Vector3> vectors = new List<Vector3>();
                foreach (var item in model.Vertexes)
                {
                    vectors.Add(camera.Model2Camera(item));
                }
                for (int i = 0; i < model.PolygonContainer.Count; i++)
                {
                    for (int j = 0; j < model.PolygonContainer.VertexInPolygonCount(i); j++)
                    {
                        int A = model.PolygonContainer[i, j];
                        int B = model.PolygonContainer[i, (j+1)% model.PolygonContainer.VertexInPolygonCount(i)];
                        PointF p1 = new PointF(vectors[A].X, vectors[A].Y);
                        PointF p2 = new PointF(vectors[B].X, vectors[B].Y);
                        g.DrawLine(Pens.Black, screen.Real2Screen(p1), screen.Real2Screen(p2));
                    }
                }
            }


            return image;
        }
    }
}
