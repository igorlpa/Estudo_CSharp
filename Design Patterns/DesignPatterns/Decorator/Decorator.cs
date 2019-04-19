using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Decorator : VisualComponent
    {
        protected VisualComponent _component;

        public Decorator(VisualComponent component)
        {
            _component = component;
        }

        public override void Draw()
        {
            _component.Draw();
        }

        public override void Resize()
        {
            _component.Resize();
        }

    }
}
