using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour
{

    public Rigidbody2D myBody;

    public Vector3 startDir;
    public float force;

    int randDir;

    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        //sets a random direction for the ball to move
        randDir = Random.Range(0,2); 
        if(randDir == 0)
        {
            startDir.x = -1;
        }
        else if(randDir == 1)
        {
            startDir.x = 1;
        }


        //adds force to the ball so that it moves in the direction of the force being added
        myBody.AddForce(startDir * force);
    }

    // Update is called once per frame
    void Update()
    {
        //checks if one of the player's score is 10 and if true switches the screen to restart game
        if(myManager.playerOneScore == 10 || myManager.playerTwoScore == 10)
        {
            GoToScene("Restart Game");
        }
    }


    //checks for collision with the left and right borders and if true increases score either for player one or two based on the border
    private void OnTriggerEnter2D( Collider2D collison )
    {
        if(collison.gameObject.name == "Left Border")
        {
            myManager.playerTwoScore++;
            transform.position = new Vector3(0, 0, 0);
        }

        if(collison.gameObject.name == "Right Border")
        {
            myManager.playerOneScore++;
            transform.position = new Vector3(0, 0, 0);
        }


        //randomises the ball's direction
        randDir = Random.Range(0,2);
        if(randDir == 0)
        {
            startDir.x = -1;
        }
        else if(randDir == 1)
        {
            startDir.x = 1;
        }

        //sets the ball's velocity to 0 so that the ball doesn't gain more force as it keeps bouncing or resetting
        myBody.velocity = Vector3.zero;         
        myBody.AddForce(startDir * force);

    }

    //fuction to switch scene
    void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);          //Switches the scene to the assigned scene set in Unity Editor
    }

}
