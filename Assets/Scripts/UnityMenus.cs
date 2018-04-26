using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UnityMenus {

    [MenuItem("UAT/Hello World %H", false, 250)]
    private static void HelloWorld()
    {
        Debug.Log("Hello World");
    }

    [MenuItem("UAT/Menu Tests/Goodbye World %G", false, 220)]
    private static void GoodbyeWorld()
    {
        Debug.Log("Goodbye World!");
    }

    [MenuItem("UAT/Only For GameObjects", false, 100)]
    private static void IsGameObject()
    {
        Debug.Log("This is a GameObject");
    }

    [MenuItem("UAT/Only For GameObjects", true, 100)]
    private static bool IsGameObjectValidation()
    {
        return Selection.activeObject.GetType() == typeof(GameObject);
    }

    [MenuItem("Assets/Create/Weapon")]
    public static void AssetsTest()
    {
        GameObject weapon = new GameObject();
        weapon.gameObject.name = "Weapon";
        weapon.AddComponent<Weapon>();
        weapon.AddComponent<MeshFilter>();
        weapon.AddComponent<MeshRenderer>();
        weapon.AddComponent<CapsuleCollider>();
    }
}
