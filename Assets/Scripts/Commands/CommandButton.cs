using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

#nullable enable

namespace Commands
{
    [UxmlElement]
    public partial class CommandButton : Button, ICommandSource
    {
        RelayCommand? command;

        public object? CommandParameter { get; set; } = null;

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

                OnCanExecuteChanged();
            }
        }
#nullable enable

        public CommandButton()
        {
            RegisterCallback<ClickEvent>(OnClick);
        }

        private void OnClick(ClickEvent evt)
        {
            if (Command != null && Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }

        private void OnCanExecuteChanged()
        {
            SetEnabled(Command?.CanExecute(CommandParameter) ?? true);
        }
    }
}
