using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public class DellDesktopBuilder : DesktopBuilder
    {
        public override DesktopBuilder BuildGraphics()
        {
            desktop.Graphics = "Nvidia RTX 2050 4GB VRAM";
            return this;
        }

        public override DesktopBuilder BuildKeyboard()
        {
            desktop.Keyboard = "Dell keyboard";
            return this;
        }

        public override DesktopBuilder BuildMonitor()
        {
            desktop.Monitor = "Dell Monitor IPS Display";
            return this;
        }

        public override DesktopBuilder BuildMouse()
        {
            desktop.Mouse = "Dell Mouser";
            return this;
        }

        public override DesktopBuilder BuildProcessor()
        {
            desktop.Processor = "Intel i3 13th Generation";
            return this;
        }

        public override DesktopBuilder BuildRAM()
        {
            desktop.RAM = "8GB DDR$ RAM";
            return this;
        }

        public override DesktopBuilder BuildSpeaker()
        {
            desktop.Speaker = "Dell Speaker";
            return this;
        }
    }
}
