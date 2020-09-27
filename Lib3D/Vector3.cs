using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public struct Vector3
    {
        private float[] data;
        public float X { get => data[0]; set => data[0] = value; }
        public float Y { get => data[1]; set => data[1] = value; }
        public float Z { get => data[2]; set => data[2] = value; }

        public Vector3(float x, float y, float z)
        {
            data = new float[3];
            X = x;
            Y = y;
            Z = z;
        }
        public static implicit operator Vector3(Vector4 v)
        {
            return v.W == 0 ? new Vector3(v.X, v.Y, v.Z) : new Vector3(v.X / v.W, v.Y / v.W, v.Z / v.W);
        }
    }
}
