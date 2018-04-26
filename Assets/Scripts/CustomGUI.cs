using UnityEngine;
using UnityEditor;

public class CustomGUI : EditorWindow {

    string myString = "Hello World!";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 2.567f;

    [MenuItem("UAT/New Window", false, 90)]
    public static void OpenNewWindow()
    {
        EditorWindow.GetWindow(typeof(CustomGUI));
    }

    
    void OnGUI()
    {
        GUILayout.Label("This is a new window", EditorStyles.boldLabel);

        myString = EditorGUILayout.TextField("Text ", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);

        myBool = EditorGUILayout.Toggle("Toggle", myBool);

        myFloat = EditorGUILayout.Slider("Float", myFloat, -5, 5);

        EditorGUILayout.EndToggleGroup();
    }
}
