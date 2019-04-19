using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Class1
    {
        public static void Main(string [] args)
        {

            VisualComponent component = new ShadowDecorator( new BorderDecorator(new VisualComponent()));
            component.Draw();
            component.Resize();

            component.Draw();
        }
    }
}
