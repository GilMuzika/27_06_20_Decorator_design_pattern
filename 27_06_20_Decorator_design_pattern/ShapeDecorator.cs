using System;
using System.Collections.Generic;
using System.Text;

namespace _27_06_20_Decorator_design_pattern
{
    internal abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {         
            decoratedShape.Draw();
        }


    }
}
