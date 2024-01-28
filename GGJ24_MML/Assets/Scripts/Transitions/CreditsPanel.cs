using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPanel : MonoBehaviour
{
    public GameObject CreditsPanelObject;



    public void ToggleCreditsPanel() {
        if (CreditsPanelObject.activeSelf) {
            CreditsPanelObject.SetActive(false);
        } else {
            CreditsPanelObject.SetActive(true);
        }
    }


}
