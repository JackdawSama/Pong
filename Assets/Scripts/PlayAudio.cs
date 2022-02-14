using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D thatObject)             
    {
        if(thatObject.gameObject.name == "Ball")                //Checks if there's a collision with an object named Ball
        {
                GetComponent<AudioSource>().Play();             //Obtains the Audio Source component and plays the audio file attached to it
            }
    }
}
