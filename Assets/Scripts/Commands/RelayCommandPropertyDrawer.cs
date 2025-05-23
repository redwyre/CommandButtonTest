using UnityEditor;
using UnityEngine.UIElements;
using Commands;

#nullable enable

namespace Commands
{
    /// <summary>
    /// RelayCommandPropertyDrawer is a custom property drawer for the 
    /// RelayCommand class. Without this the field will not be displayed in 
    /// the inspector.
    /// </summary>
    [CustomPropertyDrawer(typeof(RelayCommand))]
    public class RelayCommandPropertyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var field = new RelayCommandElement(property.displayName);
            field.AddToClassList(RelayCommandElement.alignedFieldUssClassName);

            return field;
        }
    }
}
