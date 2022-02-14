using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public int playerOneScore;
    public int playerTwoScore;
    
    public Text playerOneText;
    public Text playerTwoText;
    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;                                     //Sets Player 1 score to 0 at the beginning of the game
        playerTwoScore = 0;                                     //Sets Player 2 score to 0 at the beginning of the game
    }

    // Update is called once per frame
    void Update()
    {
        playerOneText.text = "P1 : " + playerOneScore;          //Displays Player 1's score
        playerTwoText.text = "P2 : " + playerTwoScore;          //Displays Player 2's score
    }

    
}
