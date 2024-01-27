using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NpcBehaviour : MonoBehaviour
{

    public RoundKeeper rk;

    public GameObject npc;
    public int npcType;
    /// <summary>
    /// there will be 4 types of npcs
    /// 0
    /// 1
    /// 2
    /// 3
    /// 
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        npc = GameObject.Find("NPC");
    }



    // Update is called once per frame
    public void newGuy()
    {
        rk.timer.Interval = 20000;//1000 = 1 second\\//Use percentage for viewing time
        rk.timer.Start();
        npcType = Random.Range(0,4);
    }
}
