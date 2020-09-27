using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib3D
{
    public struct Vector4
    {
        private float[] data;
        public float X { get => data[0]; set => data[0] = value; }
        public float Y { get => data[1]; set => data[1] = value; }
        public float Z { get => data[2]; set => data[2] = value; }
        public float W { get => data[3]; set => data[3] = value; }
        public float this[int index] { get => data[index]; set => data[index] = value; }
        public Vector4(float x, float y, float z, float w = 1)
        {
            data = new float[4];
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        public static implicit operator Vector4(Vector3 v)
        {
            return new Vector4(v.X, v.Y, v.Z) ;
        }
        public static Vector4 operator *(Matrix4 matrix, Vector4 vector)
        {
            Vector4 v = new Vector4(0, 0, 0, 0);
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    v[row] += matrix[row, column] * vector[column];
            return v;
        }
    }
}
