using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern.Models
{
    public class MenuOptions
    {
        private ICommand _openCommad;
        private ICommand _saveCommand;
        public MenuOptions(ICommand openCommad, ICommand saveCommand)
        {
            this._openCommad = openCommad;
            this._saveCommand = saveCommand;
        }

        public void OnClickOpen() => _openCommad.Execute();
        public void OnClickSave() => _saveCommand.Execute();

    }
}
