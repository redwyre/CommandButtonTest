using System;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

#nullable enable

namespace Commands
{
    /// <summary>
    /// CommandButton is a button that can be bound to a RelayCommand. It 
    /// will disable itself if the command is unable to be executed.
    /// </summary>
    [UxmlElement]
    public partial class CommandButton : Button
    {
        RelayCommand? command;

        // Unity does not currently allow for nullability annotations on UxmlAttribute properties (6000.0.47)
#nullable disable
        [UxmlAttribute]
        [CreateProperty]
        public RelayCommand Command
        {
            get => command;
            set
            {
                if (command == value) return;

                if (command != null)
                {
                    command.CanExecuteChanged -= OnCanExecuteChanged;
                }

                command = value;

                if (command != null)
                {
                    command.CanExecuteChanged += OnCanExecuteChanged;
                }

                OnCanExecuteChanged(null, EventArgs.Empty);
            }
        }
#nullable enable

        public CommandButton()
        {
            RegisterCallback<ClickEvent>(OnClick);
        }

        private void OnClick(ClickEvent evt)
        {
            if (Command != null && Command.CanExecute(null))
            {
                Command.Execute(null);
            }
        }

        private void OnCanExecuteChanged(object sender, EventArgs eventArgs)
        {
            SetEnabled(Command?.CanExecute(null) ?? true);
        }
    }
}
