using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UIElements;

#nullable enable

namespace Commands
{
    /// <summary>
    /// Interface for a command source. Copied from WPF but not really 
    /// necessary.
    /// </summary>
    public interface ICommandSource
    {
        public RelayCommand? Command { get; }

        public object? CommandParameter { get; }

        //public VisualElement CommandTarget { get; }
    }
}