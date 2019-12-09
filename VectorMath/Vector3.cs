using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Vector Addition
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Vector Subtraction 
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        // Vector Scaling 
        public static Vector3 operator *(Double a, Vector3 b)
        {
            return new Vector3(a * b.X, a * b.Y, a * b.Z);
        }
        public static Vector3 operator *(Vector3 b, Double a )
        {
            return new Vector3(a * b.X, a * b.Y, a * b.Z);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return (a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return (a.X != b.X || a.Y != b.Y || a.Z != b.Z);
        }
    }
}
