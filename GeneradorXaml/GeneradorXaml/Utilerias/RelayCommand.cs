using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GeneradorXaml.Utilerias
{
    public class RelayCommand : ICommand
    {


        public Action<object> ActionExecute { get; set; }

        public Func<object, bool> ActionCanExecute { get; set; }

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<object,bool> canExecute =null)
        {
            if(ActionExecute == null)
                ActionExecute = (i) => { };

            if (canExecute == null)
                canExecute = (i) => true;


            this.ActionExecute = execute;
            this.ActionCanExecute = canExecute;
            
        }

        public bool CanExecute(object parameter)
        {
            return ActionCanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            ActionExecute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
