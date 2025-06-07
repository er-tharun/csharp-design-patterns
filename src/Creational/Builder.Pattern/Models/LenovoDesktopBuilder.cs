using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public class LenovoDesktopBuilder : DesktopBuilder
    {
        public override DesktopBuilder BuildGraphics()
        {
            desktop.Graphics = "Nvidia RTX 4060 6GB VRAM";
            return this;
        }

        public override DesktopBuilder BuildKeyboard()
        {
            desktop.Keyboard = "Lenovo Keyboard";
            return this;
        }

        public override DesktopBuilder BuildMonitor()
        {
            desktop.Monitor = "Lenovo IPS display Monitor";
            return this;
        }

        public override DesktopBuilder BuildMouse()
        {
            desktop.Mouse = "Lenovo Mouse";
            return this;
        }

        public override DesktopBuilder BuildProcessor()
        {
            desktop.Processor = "Intel i7 13th gen Processor";
            return this;
        }

        public override DesktopBuilder BuildRAM()
        {
            desktop.RAM = "32GB DDR5 RAM";
            return this;
        }

        public override DesktopBuilder BuildSpeaker()
        {
            desktop.Speaker = "DLOBY ATOMS Speaker";
            return this;
        }
    }
}
