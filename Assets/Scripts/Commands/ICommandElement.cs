using System;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Commands;

namespace Commands
{
    /// <summary>
    /// ICommandElement is a UI element that represents a ICommand. 
    /// This is used to keep the UI inline with everything else.
    /// </summary>
    public class ICommandElement : BaseField<ICommandElement>
    {
        public ICommandElement(string label)
            : base(label, new Label("Command for binding")
            {
                style = {
                    flexGrow = 1
                },
                enabledSelf = false
            })
        {
        }
    }
}
