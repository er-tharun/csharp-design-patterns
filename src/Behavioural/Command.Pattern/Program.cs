using Command.Pattern.Models;

namespace Command.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommand openCommand = new OpenCommad(new Document());
            ICommand saveCommand = new SaveCommand(new Document());

            MenuOptions options = new MenuOptions(openCommand, saveCommand);

            options.OnClickOpen();
            options.OnClickSave();


        }
    }
}
