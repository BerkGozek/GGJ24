using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Diagnostics;
using Debug = UnityEngine.Debug;


public class RoundKeeper : MonoBehaviour
{
    public NpcBehaviour npcb;

    public Timer timer = new Timer();
    public Stopwatch timerStopwatch = new Stopwatch();

    public int lives = 10;
    public int score = 0;


    public void StartTimer(){
        timer.Interval = 20000;//1000 = 1 second\\//Use percentage for viewing time
        timer.Start();
        timerStopwatch.Reset();
        timerStopwatch.Start();
    }
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Debug.Log("Time's up!");
        lives--;
        timer.Stop();
    }
    public void Guess(int type){
        if(type == npcb.npcType){
            Debug.Log("Correct!");
            score += 500;
            if(timerStopwatch.ElapsedMilliseconds < 10000){
                score += 500;
            }
            
        }else{
            Debug.Log("Wrong!");
            lives--;
            score -=500;
            timer.Stop();
            timerStopwatch.Stop();
        }
    }
}
