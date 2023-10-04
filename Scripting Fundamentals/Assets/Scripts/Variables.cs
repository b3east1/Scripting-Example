using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaring Variable
    // Public Memeber/Gobal Variables
    public float MoveSpeed = 10f;
    public int PlayerScore = 0;
    public string PlayerName = "John Voe";
    public bool IsPlayerActive = true;

    // Private Member/Gobal Variables
    private float _maxspeed = 100f;
    private int _totalScore = 0;
    private string _userName = "John006";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Declaring local variables
        float horizontalInput = Input.GetAxis("Horizontal"); 
        
    }
 
    private void UpdateScore(int amount)
    {
        //using local variable to update the total score

        _totalScore += amount;
    }
}
