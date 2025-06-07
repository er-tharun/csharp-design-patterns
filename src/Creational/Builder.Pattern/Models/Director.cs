using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public class Director
    {
        private DesktopBuilder _builder;
        public Director(DesktopBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.BuildProcessor().BuildRAM().BuildGraphics().BuildMonitor().BuildMouse().BuildKeyboard().BuildSpeaker();
            _builder.GetDesktop().Display();
        }
    }
}
