using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteDoors : MonoBehaviour
{
    int i = 0;
    public Text roleView;
    public Button ViewButton;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DoorButton(int doorNumber)
    {
        GameScript.VotedOnDoors[doorNumber]++;
        i++;
            DoorVoteInit.doorButton.gameObject.SetActive(false);
            DoorVoteInit.doorButton2.gameObject.SetActive(false);
            DoorVoteInit.doorButton3.gameObject.SetActive(false);
            DoorVoteInit.doorButton4.gameObject.SetActive(false);
    }

    public void MainButton(int sceneIndex)
    {
        foreach (string player in GameScript.Players.GetRange(DoorVoteInit.playerCounter, GameScript.Players.Count-DoorVoteInit.playerCounter))
        {
            if (GameScript.Dead.Contains(player)) DoorVoteInit.playerCounter++;
            else break;
        }
        if (i == 0)
        {
            roleView.text = GameScript.Players[DoorVoteInit.playerCounter - 1] + " pick your choice.";
            i++;
            ViewButton.gameObject.SetActive(false);
            if (DoorVoteInit.door1 == true)
                DoorVoteInit.doorButton.gameObject.SetActive(true);
            if (DoorVoteInit.door2 == true)
                DoorVoteInit.doorButton2.gameObject.SetActive(true);
            if (DoorVoteInit.door3 == true)
                DoorVoteInit.doorButton3.gameObject.SetActive(true);
            if (DoorVoteInit.door4 == true)
                DoorVoteInit.doorButton4.gameObject.SetActive(true);
        }
        else if (DoorVoteInit.playerCounter < GameScript.PlayerCount)
        {
            roleView.text = "Player " + DoorVoteInit.playerCounter.ToString() + "\n" + GameScript.Players[DoorVoteInit.playerCounter] + "\nPress the button to begin voting";
            DoorVoteInit.playerCounter++;
            i--;
            ViewButton.gameObject.SetActive(true);
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
