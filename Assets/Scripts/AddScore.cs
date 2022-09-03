using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    //when collision occurs on this object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //add to the variable score found in Score Manager
        ScoreManager.score++;
    }
}
