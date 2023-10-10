using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    // Declaring Variables
    public int Score = 0;
    public string PlayerName = "Rhylen";
    public int Health = 100;
    // Start is called before the first frame update
    void Start()
    {
        IncreseScore();
        PrintPlayerName();
        DecreaseHealth();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void IncreseScore()
    {
        Score = Score + 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health = Health - 20;
 
    }


}
