using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

#nullable enable

namespace Commands
{
    public class ViewModel : INotifyBindablePropertyChanged
    {
        public event EventHandler<BindablePropertyChangedEventArgs>? propertyChanged;

        public void SetProperty<T>(ref T value, T newValue, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(value, newValue))
                return;

            value = newValue;

            propertyChanged?.Invoke(this, new BindablePropertyChangedEventArgs(propertyName));
        }
    }
}
