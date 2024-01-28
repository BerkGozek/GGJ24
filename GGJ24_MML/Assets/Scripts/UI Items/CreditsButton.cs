using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
    {
    private GameObject button;   
    private Renderer renderer;

    private CreditsPanel cP;

    void Start() {
        button = gameObject;
        renderer = gameObject.GetComponent<Renderer>();
        cP = GameObject.Find("OperationHandler").GetComponent<CreditsPanel>();
        
    }

    void OnMouseDown() {
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        Debug.Log("Button Pressed");
        cP.ToggleCreditsPanel();
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
