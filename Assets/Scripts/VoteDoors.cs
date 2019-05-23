using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteDoors : MonoBehaviour
{
    int i = 0;
    public Text roleView;
    private int playerCounter = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DoorButton(int doorNumber)
    {
        if (doorNumber == 1)
        {
            GameScript.VotedOnDoors[1]++;
        }
        else if (doorNumber == 2)
        {
            GameScript.VotedOnDoors[2]++;
        }
        else if (doorNumber == 3)
        {
            GameScript.VotedOnDoors[3]++;
        }
        else if (doorNumber == 4)
        {
            GameScript.VotedOnDoors[4]++;
        }
    }

    public void MainButton(int sceneIndex)
    {
        if (i == 0)
        {
            roleView.text = GameScript.Players[playerCounter - 1] + " pick your choice.";
            i++;
        }
        else if (playerCounter < GameScript.PlayerCount)
        {
            roleView.text = "Player " + playerCounter.ToString() + "\n" + GameScript.Players[playerCounter] + "\nPress the button to begin voting";
            playerCounter++;
            i--;
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

}
