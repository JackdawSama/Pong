using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{

    public float speed;
    public KeyCode moveUp;
    public KeyCode moveDown;


    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if(Input.GetKey(moveUp))                            //Checks for input and moves the paddle up
        {
            newPos.y += speed * Time.deltaTime;
        }

        if(Input.GetKey(moveDown))                          //Checks for input and moves the paddle up
        {
            newPos.y -= speed * Time.deltaTime;
        }

        transform.position = newPos;
    }
}
