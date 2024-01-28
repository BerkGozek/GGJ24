using UnityEngine;
using TMPro;

public class NpcBehaviour : MonoBehaviour
{
    public RoundKeeper rk;

    public GameObject npc;
    public int npcType;
    public Answers a;
    public TextMeshPro typeText;

    public 
    /// <summary>
    /// there will be 4 types of npcs
    /// 0
    /// 1
    /// 2
    /// 3
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        rk = GameObject.Find("OperationHandler").GetComponent<RoundKeeper>();
        npc = GameObject.Find("NPC");
    }

    // This method can be called to spawn a new NPC and start a new round
    public void NewGuy()
{
    npcType = Random.Range(0, 4);
    rk.StartTimer(); // Start the round timer
    a.newAnswers();

    // Check the value of npcType and set typeText.text accordingly
    if (npcType == 0)
    {
        typeText.text = "Tech Geeks";
    }
    else if (npcType == 1)
    {
        typeText.text = "Children";
    }
    else if (npcType == 2)
    {
        typeText.text = "Old People";
    }
    else if (npcType == 3)
    {
        typeText.text = "Gym Bros";
    }
}

}
