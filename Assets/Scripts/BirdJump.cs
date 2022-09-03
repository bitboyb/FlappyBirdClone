using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    public GameOver gameManager;
    public float velocity = 1;
    // we need a reference to the rigidbody component attached to this object
    private Rigidbody2D rb;
    public GameObject pipe;
    //this is a reference to the audio source on the object
    private AudioSource BirdSound;
    //this is the check if the game over screen is enabled
    private bool GameOverEnabled = false;

    //You can use [SerializeField] to expose private variables in the editor, this is useful if you want to set it, but for it not the altered from another script
    [SerializeField]
    private AudioClip JumpSFX;
    [SerializeField]
    private AudioClip HitSFX;


    // Start is called before the first frame update
    void Start()
    {
        //this gets the variable rb to the rigidbody component from the object
        rb = GetComponent<Rigidbody2D>();
        //this gets the audio source component from the object
        BirdSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if mouse left click is down (pressed)
        if(Input.GetMouseButtonDown(0))
        {
            //rigid body velocity = Vector2.up * our variable
            rb.velocity = Vector2.up * velocity;

            //if gameover screen is not showing
            if (GameOverEnabled == false)
            {
                //set our audiosource to play this sound
                BirdSound.clip = JumpSFX;
                //play the audio source
                BirdSound.Play();
            }
            
        }
    }

    //if collision is to occur
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //the game over UI bool is set to true, this is so we do not play the flapping sound when pressing left click
        GameOverEnabled = true;
        //this changes the audiosource sound effect
        BirdSound.clip = HitSFX;
        //this plays the audio source
        BirdSound.Play();
        //this calls a method in our GameOver.cs called GameOverUI, since it is public we can access it
        gameManager.GameOverUI();
    }
}
