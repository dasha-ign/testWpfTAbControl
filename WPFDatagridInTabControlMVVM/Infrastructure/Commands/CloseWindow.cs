using System;
using System.Windows;
using WPFDatagridInTabControlMVVM.Infrastructure.Commands.Base;

namespace WPFDatagridInTabControlMVVM.Infrastructure.Commands
{
    class CloseWindow : Command
    {
        private static Window GetWindow(object p) => p as Window ?? App.FocusedWindow ?? App.ActivedWindow;

        protected override bool CanExecute(object p) => GetWindow(p) != null;

        protected override void Execute(object p) => GetWindow(p)?.Close();
    }
}
