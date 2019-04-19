using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ShadowDecorator: Decorator
    {

        
        public ShadowDecorator(VisualComponent component) : base(component)
        {
                
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("-> desenhando sombra");
        }

        public override void Resize()
        {
            base.Resize();
            Console.WriteLine("-> resize sombra");
        }
    }
}
