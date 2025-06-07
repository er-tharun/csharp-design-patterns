using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Pattern.Models
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
