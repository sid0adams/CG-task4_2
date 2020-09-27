using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public class Model
    {
        public List<Vector3> Vertexes { get; private set; }
        public PolygonContainer PolygonContainer { get;private set; }

        public Model()
        {
            Vertexes = new List<Vector3>();
            PolygonContainer = new PolygonContainer();
        }
        public static Model GetOXYZ(float L)
        {
            Model model = new Model();
            model.Vertexes.Add(new Vector3(0, 0, 0));
            model.Vertexes.Add(new Vector3(L, 0, 0));
            model.Vertexes.Add(new Vector3(0, L, 0));
            model.Vertexes.Add(new Vector3(0, 0, L));
            model.PolygonContainer.Add(new List<int> { 0, 1 });
            model.PolygonContainer.Add(new List<int> { 0, 2 });
            model.PolygonContainer.Add(new List<int> { 0, 3 });
            return model;
        }
        public static Model GetCube(float size)
        {
            Model model = new Model();
            float t = size / 2;
            model.Vertexes.Add(new Vector3(t, t, t));
            model.Vertexes.Add(new Vector3(t, t, -t));
            model.Vertexes.Add(new Vector3(t, -t, t));
            model.Vertexes.Add(new Vector3(t, -t, -t));
            model.Vertexes.Add(new Vector3(-t, -t, t));
            model.Vertexes.Add(new Vector3(-t, -t, -t));
            model.Vertexes.Add(new Vector3(-t, t, t));
            model.Vertexes.Add(new Vector3(-t, t, -t));
            List<int> PolygonDown = new List<int>();
            List<int> PolygonUp = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                PolygonDown.Add(2 * i);
                PolygonUp.Add(2 * i + 1);
                model.PolygonContainer.Add(new List<int>
                {
                    2 * i,
                    2 * i + 1,
                    (2 *i + 3) % (2*4),
                    (2 * i + 2) % (2*4)
                });
            }
            model.PolygonContainer.Add(PolygonDown);
            model.PolygonContainer.Add(PolygonUp);
            return model;
        }
        public static Model GetTetrahedron(float width)
        {
            Model model = new Model();
            float R = width / (float)Math.Sqrt(3);
            float t = width *(float) Math.Sqrt(6) / 3;
            Vector4 D = new Vector4(0, R, -t);
            for (int index = 0; index < 3; index++)
            {
                Matrix4 Rotation = Matrix4.RotationMatrix(2, (float)(index * 2 * Math.PI / 3));
                model.Vertexes.Add(Rotation * D);
            }
            model.Vertexes.Add(new Vector3(0, 0, t));
            model.PolygonContainer.Add(new List<int>() { 0, 1, 2 });
            model.PolygonContainer.Add(new List<int>() { 0, 1, 3 });
            model.PolygonContainer.Add(new List<int>() { 1, 2, 3 });
            model.PolygonContainer.Add(new List<int>() { 2, 0, 3 });
            return model;
        }
        public static Model GetOctahedron( float width)
        {
            Model model = new Model();
            float R = width / (float)Math.Sqrt(2);
            float t = width / ((float)Math.Sqrt(2)*2);
            Vector4 D = new Vector4(0, R, 0);
            for (int index = 0; index < 4; index++)
            {
                Matrix4 Rotation = Matrix4.RotationMatrix(2, (float)(index * 2 * Math.PI / 4));
                model.Vertexes.Add(Rotation * D);
            }
            model.Vertexes.Add(new Vector3(0, 0, t));
            model.Vertexes.Add(new Vector3(0, 0, -t));
            model.PolygonContainer.Add(new List<int>() { 0, 1, 4 });
            model.PolygonContainer.Add(new List<int>() { 1, 2, 4 });
            model.PolygonContainer.Add(new List<int>() { 2, 3, 4 });
            model.PolygonContainer.Add(new List<int>() { 3, 0, 4 });
            model.PolygonContainer.Add(new List<int>() { 0, 1, 5 });
            model.PolygonContainer.Add(new List<int>() { 1, 2, 5 });
            model.PolygonContainer.Add(new List<int>() { 2, 3, 5 });
            model.PolygonContainer.Add(new List<int>() { 3, 0, 5 });
            return model;
        }
        public static Model GetIcosahedron(float size)
        {
            Model model = new Model();
            float A = (float)(2 * size / (Math.Sqrt(2 * (5 + Math.Sqrt(5)))));
            float R5 = (float)(A * Math.Sqrt(10) * Math.Sqrt(5 + Math.Sqrt(5)) / 10);
            float Hm = (float)Math.Sqrt(A * A - Math.Pow(R5, 2));
            float t = size / 2;
            Vector4 U = new Vector4(0, R5, t - Hm);
            Matrix4 Rotation = Matrix4.RotationMatrix(2, (float)(-2 * Math.PI / 10));
            Vector4 D = Rotation * new Vector4(0,R5,-t+Hm);
            for (int index = 0; index < 5; index++)
            {
                Rotation = Matrix4.RotationMatrix(2, (float)(index * 2 * Math.PI / 5));
                model.Vertexes.Add(Rotation * D);
                model.Vertexes.Add(Rotation * U);
            }
            List<int> PolygonDown = new List<int>();
            List<int> PolygonUp = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    PolygonDown.Add(i);
                else
                    PolygonUp.Add(i);
                model.PolygonContainer.Add(new List<int>
                {
                    i,
                    (i+1)%10,
                    (i+2)%10
                });
            }
            model.PolygonContainer.Add(PolygonDown);
            model.PolygonContainer.Add(PolygonUp);
            model.Vertexes.Add(new Vector3(0, 0, t));
            model.Vertexes.Add(new Vector3(0, 0, -t));
            for (int i = 0; i < 5; i++)
            {
                model.PolygonContainer.Add(new List<int>
                {
                    PolygonUp[i],
                    10,
                    PolygonUp[(i+1)%5]
                });
                model.PolygonContainer.Add(new List<int>
                {
                    PolygonDown[i],
                    11,
                    PolygonDown[(i+1)%5]
                });
            }
            return model;
        }
    }
}
