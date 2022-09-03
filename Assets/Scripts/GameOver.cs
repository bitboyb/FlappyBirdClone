using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//you need UnityEngine.SceneManagement to load scenes
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //here we can add a reference to our game over UI
    public GameObject gameOverCanvas;

    //Start is called at the begining and only once
    private void Start()
    {
        Time.timeScale = 1;
    }

    //this method can be access publically and does not return a value
    public void GameOverUI()
    {
        //this sets our referenced UI to visible
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    //same as the method above, it does not return a value
    public void Replay()
    {
        //this line loads scene 0, which is the first scene in the build (you can add scenes and find out their value by going to file > build settings
        SceneManager.LoadScene(0);
    }

}
