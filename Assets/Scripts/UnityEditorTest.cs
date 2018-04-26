using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class UnityEditorTest : MonoBehaviour {

    private void Awake()
    {
        Debug.Log(" This is the Awake Funciton");
    }

    // Use this for initialization
    void Start () {

        Debug.Log("This is the start Function");
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("This is the update function");
		
	}
}
