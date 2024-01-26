using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiaStor : MonoBehaviour
{
    public DiaBoxCont DBC;

    public List<string> Dialogs = new List<string>();
    public List<string> Names = new List<string>();

    void private void Start() {
        DBC = GameObject.Find("DiaBox").GetComponent<DiaBoxCont>();
    }

    public void startDialog(){

    }


}
