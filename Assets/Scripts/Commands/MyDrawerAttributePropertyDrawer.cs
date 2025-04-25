using UnityEditor;
using UnityEngine.UIElements;
using Commands;

#nullable enable

namespace Commands
{
    [CustomPropertyDrawer(typeof(RelayCommand))]
    public class MyDrawerAttributePropertyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var field = new RelayCommandElement(property.displayName);
            field.AddToClassList(RelayCommandElement.alignedFieldUssClassName);

            return field;
        }
    }
}
