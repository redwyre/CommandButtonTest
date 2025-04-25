using System;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Commands;

namespace Commands
{
    /// <summary>
    /// RelayCommandElement is a UI element that represents a RelayCommand. 
    /// This is used to keep the UI inline with everything else.
    /// </summary>
    public class RelayCommandElement : BaseField<RelayCommand>
    {
        public RelayCommandElement(string label)
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
