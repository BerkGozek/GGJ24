using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public NpcBehaviour npcBehaviour;

    void Start()
    {
        npcBehaviour.NewGuy(); // Start the first round
    }
}
