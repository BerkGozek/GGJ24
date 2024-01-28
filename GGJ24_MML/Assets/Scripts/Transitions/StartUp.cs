using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartUp : MonoBehaviour
{
    private Renderer B1;
    private Renderer B2;
    private Renderer B3;
    private Renderer B4;
    private Renderer B5;


    private Renderer StartSign;
    private GameObject DL;
    private GameObject SLL;
    private GameObject SLR;

    public GameObject Blackout;



    // Start is called before the first frame update
    void Start()
    {
        DL = GameObject.Find("Directional Light");
        SLR = GameObject.Find("Right");
        SLL = GameObject.Find("Left");
        StartSign = GameObject.Find("Start").GetComponent<Renderer>();
        B1 = GameObject.Find("Body1").GetComponent<Renderer>();
        B2 = GameObject.Find("Body2").GetComponent<Renderer>();
        B3 = GameObject.Find("Body3").GetComponent<Renderer>();
        B4 = GameObject.Find("Body4").GetComponent<Renderer>();
        B5 = GameObject.Find("Body5").GetComponent<Renderer>();

    }

    IEnumerator TransitionScene() {

        StartSign.material.DisableKeyword("_EMISSION");
        Destroy(SLL);
        yield return new WaitForSeconds(1);
        Destroy(SLR);
        yield return new WaitForSeconds(1);
        ToggleMainSign();//close
        yield return new WaitForSeconds(1);
        ToggleMainSign();//open
        yield return new WaitForSeconds(1);
        ToggleMainSign();//close
        yield return new WaitForSeconds(0.20f);
        ToggleMainSign();//open
        yield return new WaitForSeconds(0.20f);
        ToggleMainSign();//close
        DL.transform.Rotate(-90, DL.transform.eulerAngles.y, DL.transform.eulerAngles.z);
        Blackout.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainScene");

    }

    public void SwitchScenes ()
    {
        
        StartCoroutine(TransitionScene());

    }
    public void ToggleMainSign() {
        bool isEmissionEnabled = B1.material.IsKeywordEnabled("_EMISSION");
        if (isEmissionEnabled) {
            B1.material.DisableKeyword("_EMISSION");
            B2.material.DisableKeyword("_EMISSION");
            B3.material.DisableKeyword("_EMISSION");
            B4.material.DisableKeyword("_EMISSION");
            B5.material.DisableKeyword("_EMISSION");
        } else {
            B1.material.EnableKeyword("_EMISSION");
            B2.material.EnableKeyword("_EMISSION");
            B3.material.EnableKeyword("_EMISSION");
            B4.material.EnableKeyword("_EMISSION");
            B5.material.EnableKeyword("_EMISSION");
        }
    }
}
