using System;
using System.Collections.Generic;
using UnityEngine;

#nullable enable

namespace Commands
{
    /// <summary>
    /// Interface for a command. This is a copy of the WPF ICommand interface.
    /// </summary>
    public interface ICommand
    {
        event Action CanExecuteChanged;

        public bool CanExecute(object? parameter);
        public void Execute(object? parameter);
    }
}
