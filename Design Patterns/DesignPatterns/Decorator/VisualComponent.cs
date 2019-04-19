using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class VisualComponent
    {
        public virtual void Draw()
        {
            Console.WriteLine("Desenho");
        }

        public virtual void Resize()
        {
            Console.WriteLine("Redimensionando");
        }
    }
}
