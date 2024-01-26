using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnim : MonoBehaviour
{
    IEnumerator Animate(float duration, string strComplete)
    {
        int i = 0;
        while (i < strComplete.Length)
        {
            this.GetComponent<TextMeshProUGUI>().text += strComplete[i++];
            yield return new WaitForSeconds(duration);
        }
    }
    public void AnimateText(string strComplete, float spacing)
    {
        StartCoroutine(Animate(0.1f,strComplete));
    }

}
