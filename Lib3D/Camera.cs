using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public class Camera
    {
        public Matrix4 View { get; set; }
        public Matrix4 Projection { get; set; }
        public Camera()
        {
            View = Matrix4.One();
            Projection = Matrix4.FrustumMatrix(-40, 40, -40, 40, -40, -120)*Matrix4.MoveMatrix(new Vector3(0,0,80)) * Matrix4.RotationMatrix(0,(float)-Math.PI/2);
        }

        public Vector3 Model2Camera(Vector3 point)
        {
            return Projection * View * ((Vector4)point);
        }
    }
}
