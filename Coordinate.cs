using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{

    public class Coordinate
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }


        public Coordinate(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;

        }

        public Coordinate()
        {
            X = 0f;
            Y = 0f;
            Z = 0f;
        }


        public override string ToString()
        {
            return "[" + X + "|" + Y + "|" + Z + "]";
        }

        public void Set(Coordinate newVertex)
        {
            X = newVertex.X;
            Y = newVertex.Y;
            Z = newVertex.Z;
        }

        public Coordinate Get()
        {
            return this;
        }

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Coordinate operator -(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Coordinate operator -(Coordinate a)
        {
            return new Coordinate(-a.X, -a.Y, -a.Z);
        }

        public static Coordinate operator *(Coordinate a, Matrix4 b)
        {
            return new Coordinate(
                a.X * b.M11 + a.Y * b.M21 + a.Z * b.M31 + 1f * b.M41,
                a.X * b.M12 + a.Y * b.M22 + a.Z * b.M32 + 1f * b.M42,
                a.X * b.M13 + a.Y * b.M23 + a.Z * b.M33 + 1f * b.M43
            );
        }

        public static Coordinate operator /(Coordinate a, float b)
        {
            return new Coordinate(a.X / b, a.Y / b, a.Z / b);
        }

        public static Coordinate operator *(Coordinate a, float b)
        {
            return new Coordinate(b * a.X, b * a.Y, b * a.Z);
        }

        public static readonly Coordinate Origin = new Coordinate();

        public static bool operator ==(Coordinate a, Coordinate b) => (a.X == b.X && a.Y == b.Y && a.Z == b.Z);

        public static bool operator !=(Coordinate a, Coordinate b) => !(a == b);


        public static implicit operator Vector3(Coordinate convert)
        {
            return new Vector3(convert.X, convert.Y, convert.Z);
        }

        public static Coordinate Vector4ToVertex(Vector4 vector4)
        {
            return new Coordinate(vector4.X, vector4.Y, vector4.Z);
        }
        public void acumular(float x, float y, float z)
        {
            this.X += x;
            this.Y += y;
            this.Z += z;
        }
    }
}
