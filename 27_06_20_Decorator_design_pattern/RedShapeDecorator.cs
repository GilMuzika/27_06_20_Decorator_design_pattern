using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _27_06_20_Decorator_design_pattern
{
    internal class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {            
        }

        public override void Draw()
        {            
            base.Draw();
            SetBorder(decoratedShape);
        }

        private void SetBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border color: Red");
        }
    }
}
