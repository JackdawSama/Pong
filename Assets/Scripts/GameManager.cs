using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public int playerOneScore;
    public int playerTwoScore;
    public float timeStart = 120;
    public Text playerOneText;
    public Text playerTwoText;
    public Text timer;
    public Text matchHistory;
    const string FILE_NAME = "High Score.txt";
    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;                                     //Sets Player 1 score to 0 at the beginning of the game
        playerTwoScore = 0;                                     //Sets Player 2 score to 0 at the beginning of the game
        timer.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        playerOneText.text = "P1 : " + playerOneScore;          //Displays Player 1's score
        playerTwoText.text = "P2 : " + playerTwoScore;          //Displays Player 2's score

        timeStart -= Time.deltaTime;
        timer.text = Mathf.Round(timeStart).ToString() + " secs";
    }

    public void WritetoFile(int playerOne, int playerTwo)       //function to write to file
    {
        StreamWriter writer = new StreamWriter(FILE_NAME,false);
        writer.Write("Player 1 : " + playerOne + "   vs   " + "Player 2 : " + playerTwo);
        writer.Close();
    }

    public void ReadfromFile()                                  //function to read from file
    {
        StreamReader reader = new StreamReader(FILE_NAME);
        string content = reader.ReadLine();
        matchHistory.text = content;
        reader.Close();
    }
    
}
