using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern.Models
{
    public class OpenCommad : ICommand
    {
        private Document _document;
        public OpenCommad(Document document)
        {
            this._document = document;
        }
        public void Execute() => _document.Open();
    }
}
