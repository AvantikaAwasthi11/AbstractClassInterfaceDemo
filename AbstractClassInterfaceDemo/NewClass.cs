using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterfaceDemo
{
    internal class NewClass
    {
        Shape shape=new Shape();






        class CheckShape
        {
            public void checkShape(Shape shape)
            {
                if(shape is Square)
                {
                    shape=(Square)shape;
                }
                else if(shape is Rectangle)
                {
                    shape = (Rectangle)shape;
                }
                shape.GetDimensions();

            }
        }
    }
}
