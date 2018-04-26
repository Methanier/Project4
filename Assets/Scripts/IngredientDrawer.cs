using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Used to tell unity you're creating your own property for the specificed class
[CustomPropertyDrawer(typeof(Ingredient))]
public class IngredientDrawer : PropertyDrawer {

    //Overrides the OnGUI function from PropertDrawer
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {

        //Beings the start of a new property
        EditorGUI.BeginProperty(position, label, property);

        //Sets the prefix label of the property
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var indent = EditorGUI.indentLevel; //Holds the current Indent variable
        EditorGUI.indentLevel = 0;          // Sets the indentLevel to 0 to keep the children of the arry from indenting in inspector

        // Creates new Rects for the new position of each variable display
        var amountRect = new Rect(position.x, position.y, 30, position.height);
        var unitRect = new Rect(position.x + 35, position.y, 50, position.height);
        var nameRect = new Rect(position.x + 90, position.y, position.width - 90, position.height);

        // Draws the new locations of each variable location
        EditorGUI.PropertyField(amountRect, property.FindPropertyRelative("amount"), GUIContent.none);
        EditorGUI.PropertyField(unitRect, property.FindPropertyRelative("unit"), GUIContent.none);
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);

        EditorGUI.indentLevel = indent; // Sets the indent back to what it was

        EditorGUI.EndProperty();        // End of the new property
    }
}
