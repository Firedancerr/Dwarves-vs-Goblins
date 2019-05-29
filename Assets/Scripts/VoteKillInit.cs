using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteKillInit : MonoBehaviour
{
    public Button[] voteButton;
    public Text[] voteText;
    public static int VoteplayerCounter;
    public Text roleView;
    public Button roleViewButton;
    // Start is called before the first frame update
    void Start()
    {
        VoteplayerCounter = 1;
        roleView.text = "Player " + VoteplayerCounter.ToString() + "\n" + GameScript.Players[VoteplayerCounter - 1] + "\nPress the button to begin voting";
        foreach (string player in GameScript.Players)
        {
            voteText[VoteplayerCounter].text = player;
            VoteplayerCounter++;
        }
        ClickOff();
    }

    public void VoteButton(int voteNumber)
    {
        ClickOff();
        GameScript.VotedOnPlayer[voteNumber]++;
        if (!(DoorVoteInit.VoteplayerCounter < GameScript.PlayerCount))
        {
            SceneManager.LoadScene(7);
        }  
        else
        {
            VoteplayerCounter++;
            roleView.text = "Player " + VoteplayerCounter.ToString() + "\n" + GameScript.Players[VoteplayerCounter - 1] + "\nPress the button to begin voting";   
        }
        
    }

    public void MainButton(int voteNumber)
    {
        ClickOn();
        roleView.text = "Player " + VoteplayerCounter.ToString() + "\n" + GameScript.Players[VoteplayerCounter - 1] + "\nVote on a player that should die.";
        GameScript.VotedOnPlayer[voteNumber]++;

    }

    void ClickOn()
    {
        for (int k = 0; k < 16; k++) voteButton[k].gameObject.SetActive(true);
        roleViewButton.gameObject.SetActive(false);
    }
    void ClickOff()
    {
        for (int k = 0; k < 16; k++) voteButton[k].gameObject.SetActive(false);
        roleViewButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
