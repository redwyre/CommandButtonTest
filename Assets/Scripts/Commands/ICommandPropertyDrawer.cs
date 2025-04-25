using UnityEditor;
using UnityEngine.UIElements;
using Commands;

#nullable enable

namespace Commands
{
    /// <summary>
    /// ICommandPropertyDrawer is a custom property drawer for the 
    /// ICommand class. Without this the field will not be displayed in 
    /// the inspector.
    /// </summary>
    [CustomPropertyDrawer(typeof(ICommand))]
    public class ICommandPropertyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var field = new ICommandElement(property.displayName);
            field.AddToClassList(ICommandElement.alignedFieldUssClassName);

            return field;
        }
    }
}
