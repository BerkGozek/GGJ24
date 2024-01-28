using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SButton : MonoBehaviour
    {
    private GameObject button;   
    private Renderer renderer;

    private StartUp sU;

    void Start() {
        button = gameObject;
        renderer = gameObject.GetComponent<Renderer>();
        sU = GameObject.Find("OperationHandler").GetComponent<StartUp>();
        
    }

    void OnMouseDown() {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        Debug.Log("Button Pressed");
        sU.SwitchScenes();
    }
    void OnMouseUp() {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        Debug.Log("Button Released");
    }    
    void OnMouseEnter() {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        Debug.Log("Mouse Enter");
    }
    void OnMouseExit() {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        Debug.Log("Mouse Exit");

    }

}
