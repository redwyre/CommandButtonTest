using System;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Commands;

namespace Commands
{
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
