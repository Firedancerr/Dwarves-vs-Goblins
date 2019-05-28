using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteDoors : MonoBehaviour
{
    public Text roleView;
    public Button ViewButton;
    public Button doorButton;
    public Button doorButton2;
    public Button doorButton3;
    public Button doorButton4;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DoorButton(int doorNumber)
    {
        GameScript.VotedOnDoors[doorNumber]++;
           doorButton.gameObject.SetActive(false);
            doorButton2.gameObject.SetActive(false);
            doorButton3.gameObject.SetActive(false);
            doorButton4.gameObject.SetActive(false);
        ViewButton.gameObject.SetActive(true);
       
        if (!(DoorVoteInit.VoteplayerCounter < GameScript.PlayerCount))
        {
            SceneManager.LoadScene(7);
        }
        else

        {
            DoorVoteInit.VoteplayerCounter++;
            roleView.text = "Player " + DoorVoteInit.VoteplayerCounter.ToString() + "\n" + GameScript.Players[DoorVoteInit.VoteplayerCounter - 1] + "\nPress the button to begin voting";

        }
    }

    public void MainButton(int sceneIndex)
    {
        /*foreach (string player in GameScript.Players.GetRange(DoorVoteInit.playerCounter, GameScript.Players.Count-DoorVoteInit.playerCounter))
        {
            if (GameScript.Dead.Contains(player)) DoorVoteInit.playerCounter++;
            else break;
        }*/

            roleView.text = GameScript.Players[DoorVoteInit.VoteplayerCounter - 1] + " pick your choice.";
            ViewButton.gameObject.SetActive(false);
            if (DoorVoteInit.door1 == true)
                doorButton.gameObject.SetActive(true);
            if (DoorVoteInit.door2 == true)
                doorButton2.gameObject.SetActive(true);
            if (DoorVoteInit.door3 == true)
                doorButton3.gameObject.SetActive(true);
            if (DoorVoteInit.door4 == true)
                doorButton4.gameObject.SetActive(true);
        
    }
    // Update is called once per frame
    void Update()
    {

    }

}
