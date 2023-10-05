using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    // Functions are blocks of code that perfom specific tasks and are not associated with any specific objet or class. They can be called and executed indpendently

    // Methods, on the other hand, are functions that are associated with a specific object or class. They can be called and excuted on instances of that object or class.

    //declare our variables
    private AudioSource _audioSource;
    private float _speed = 10f;
    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Creatubg some simple functions

    // Function to play a sound effect
    private void PlaySoundEffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }

    //Function to detect Triggers
    private void OnTriggerEnter(Collider other)
    {
        
    }

    //Creating some simple methods
    
    //Method to move the enemy

    private void MoveEnemy()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    //Method to return a value

    public int PlayerHealthy(int amount)
    {
       int _playerHealthAmount -= amount;

        return _playerHealthAmount;
    }
}
