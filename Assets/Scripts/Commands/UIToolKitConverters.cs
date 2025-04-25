using Commands;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public static class UIToolKitConverters
{

#if UNITY_EDITOR
    [InitializeOnLoadMethod]
#else
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
#endif
    public static void RegisterConverters()
    {

        ConverterGroups.RegisterGlobalConverter((ref RelayCommand x) =>
        {
            return (RelayCommand)x;
        });
    }
}



class MyRelayCommandConverter : UxmlAttributeConverter<RelayCommand>
{
    public override RelayCommand FromString(string value) => new RelayCommand((parameter) => { });
    public override string ToString(RelayCommand value) => "BindableRelayCommand";
}

