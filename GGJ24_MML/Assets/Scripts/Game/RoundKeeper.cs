using UnityEngine;
using UnityEngine.UI; // Make sure to include this for UI elements
using UnityEngine.SceneManagement;

using TMPro;


public class RoundKeeper : MonoBehaviour
{
    public NpcBehaviour npcb;
    public Slider timeSlider; // Add this for the slider reference

    private float timeLeft = 20f; // 20 seconds for each round
    private bool timerRunning = false;

    public int lives = 10;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    void Start()
    {
    

        npcb = GameObject.Find("OperationHandler").GetComponent<NpcBehaviour>();
        timeSlider.maxValue = timeLeft;
        timeSlider.value = timeLeft;
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timeSlider.value = timeLeft;
            }
            else
            {
                Debug.Log("Time's up!");
                lives--;
                timerRunning = false;
                StartNewRound(); // Add this to start a new round
            }
        }

        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }

    public void StartTimer()
    {
        timeLeft = 20f; // Reset the timer
        timerRunning = true;
    }

    public void Guess(int type)
    {
        if (type == npcb.npcType)
        {
            Debug.Log("Correct!");
            score += 500;
            if (timeLeft > 10) // Half time or less
            {
                score += 500;
            }
        }
        else
        {
            Debug.Log("Wrong!");
            lives--;
            score -= 500;
            timerRunning = false;
        }
        StartNewRound();

    }


    void StartNewRound()
    {
        if (lives > 0) // Check if the player still has lives left
        {
            npcb.NewGuy(); // Assuming npcb is your NpcBehaviour instance
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }


}
