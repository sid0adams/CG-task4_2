using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lib3D
{
    public class Matrix4
    {
        private float[,] data = new float[4, 4];
        public float this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }

        public Matrix4(float[,] Data)
        {
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                {
                    data[row, column] = Data[row, column];
                }
        }
        public static Matrix4 Zero()
        {
            float[,] data = new float[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            return new Matrix4(data);
        }
        public static Matrix4 One()
        {
            float[,] data = new float[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            return new Matrix4(data);
        }
        public static Matrix4 RotationMatrix(int axis, float angle) => RotationMatrix(axis, (float)Sin(angle), (float)Cos(angle));
        public static Matrix4 RotationMatrix(int axis, float sin, float cos)
        {
            Matrix4 newMatrix = One();
            int a1 = (axis + 1) % 3;
            int a2 = (axis + 2) % 3;

            newMatrix[a1, a1] = cos;
            newMatrix[a1, a2] = -sin;
            newMatrix[a2, a1] = sin;
            newMatrix[a2, a2] = cos;

            return newMatrix;
        }
        public static Matrix4 MoveMatrix(Vector3 vector)
        {
            Matrix4 newMatrix = One();
            newMatrix[0, 3] = vector.X;
            newMatrix[1, 3] = vector.Y;
            newMatrix[2, 3] = vector.Z;
            return newMatrix;
        }
        public static Matrix4 FrustumMatrix(float l, float r, float b, float t, float n, float f)
        {
            var Matrix = Zero();
            Matrix[0, 0] = 2 * n / (r - l);
            Matrix[1, 1] = 2 * n / (t - b);
            Matrix[2, 2] = -(f + n) / (f - n);
            Matrix[0, 2] = (r + l) / (r - l);
            Matrix[1, 2] = (t + b) / (t - b);
            Matrix[2, 3] = -2 * f * n / (f - n);
            Matrix[3, 2] = -1;
            return Matrix;
        }
        public static Matrix4 operator *(Matrix4 first, Matrix4 second)
        {
            Matrix4 newMatrix = Zero();
            for (int row = 0; row < 4; row++)
                for (int column = 0; column < 4; column++)
                    for (int index = 0; index < 4; index++)
                        newMatrix[row, column] += first[row, index] * second[index, column];
            return newMatrix;
        }
    }
}
