using System;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace Commands
{
    public interface ICommand
    {
        event Action CanExecuteChanged;

        public bool CanExecute(object? parameter);
        public void Execute(object? parameter);
    }
}
