using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaBoxCont : MonoBehaviour
{
    public GameObject DiaBox;
    // Start is called before the first frame update
    public TextAnim tA;
    void Start()
    {
        DiaBox = this.gameObject;
        tA = GameObject.Find("Jesus").GetComponent<TextAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleDiaBox()
    {
        DiaBox.SetActive(!DiaBox.activeSelf);
    }
    public void ScriptText(string script, string title)
    {
        TextMeshProUGUI box = DiaBox.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        DiaBox.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = title;
    }
    }
