using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static int score = 0;

    //Start is called at the begining and only once
    private void Start()
    {
        //this sets the score to 0 on start
        score = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        //this gets the object it is attached to (ScoreText) and converts score from an integer to a string
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
