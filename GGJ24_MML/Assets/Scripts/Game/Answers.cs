using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Answers : MonoBehaviour
{
    public RoundKeeper rk;
    public TextMeshProUGUI t1;
    public TextMeshProUGUI t2;
    public TextMeshProUGUI t3;
    public TextMeshProUGUI t4;
    public CSVRead csv;

    // Start is called before the first frame update
    void Start()
    {
        rk = GameObject.Find("OperationHandler").GetComponent<RoundKeeper>();
        t1 = GameObject.Find("T1").GetComponent<TextMeshProUGUI>();
        t2 = GameObject.Find("T2").GetComponent<TextMeshProUGUI>();
        t3 = GameObject.Find("T3").GetComponent<TextMeshProUGUI>();
        t4 = GameObject.Find("T4").GetComponent<TextMeshProUGUI>();

        csv = GameObject.Find("OperationHandler").GetComponent<CSVRead>();
    }

    public void newAnswers(){
        t1.text = csv.column1[Random.Range(0, csv.column1.Count)];
        t2.text = csv.column2[Random.Range(0, csv.column2.Count)];
        t3.text = csv.column3[Random.Range(0, csv.column3.Count)];
        t4.text = csv.column4[Random.Range(0, csv.column4.Count)];
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
