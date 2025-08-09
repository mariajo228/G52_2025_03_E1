using UnityEngine;
using System;
namespace packagePunto2D
{
    [Serializable]
    public class Punto2D
    {
        public double x;
        public double y;

        public Punto2D() { }

        public Punto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}