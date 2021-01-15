using ML.ImagePreprocessor.Desktop.Infrastructure.Commands.Base;
using System;

namespace ML.ImagePreprocessor.Desktop.Infrastructure.Commands
{
    internal class LambdaCommand<T> : Command
    {
        internal Action<T> _Execute;
        internal Func<T, bool> _CanExecute;

        public LambdaCommand(Action<T> Execute, Func<T, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke((T)parameter) ?? true;

        public override void Execute(object parameter) => _Execute((T)parameter);
    }
}
