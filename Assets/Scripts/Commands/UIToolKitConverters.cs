using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Commands;

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

