using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BorderDecorator: Decorator
    {

        public BorderDecorator(VisualComponent visualComponent): base(visualComponent)
        {

        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine( "-> desenhando borda");
        }

        public override void Resize()
        {
            base.Resize();
            Console.WriteLine("-> redimensionando com borda");
        }
    }
}
