using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern.Models
{
    public class Desktop
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Graphics { get; set; }
        public string Monitor { get; set; }
        public string Mouse { get; set; }
        public string Keyboard { get; set; }
        public string Speaker { get; set; }
        public Desktop()
        {
            
        }

        public void Display()
        {
            Console.WriteLine($"{nameof(Processor)} : {this.Processor}");
            Console.WriteLine($"{nameof(RAM)} : {this.RAM}");
            Console.WriteLine($"{nameof(Graphics)} : {this.Graphics}");
            Console.WriteLine($"{nameof(Monitor)} : {this.Monitor}");
            Console.WriteLine($"{nameof(Mouse)} : {this.Mouse}");
            Console.WriteLine($"{nameof(Keyboard)} : {this.Keyboard}");
            Console.WriteLine($"{nameof(Speaker)} : {this.Speaker}");
        }
    }
}
