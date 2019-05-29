using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteKillInit : MonoBehaviour
{
    public Button[] voteButton;
    public Text[] voteText;
    public int VoteplayerCounter = 1;
    public Text roleView;
    public Button roleViewButton;

    void Start()
    {
        int i = 1;
        roleView.text = "Player " + VoteplayerCounter.ToString() + "\n" + GameScript.Players[VoteplayerCounter - 1] + "\nPress the button to begin voting";
        foreach (string player in GameScript.Players)
        {
            voteText[i - 1].text = player;
            i++;
        }
        ClickOff();
    }

    public void VoteButton(int voteNumber)
    {
        
        GameScript.VotedOnPlayer[voteNumber]++;
        if (!(VoteplayerCounter < GameScript.PlayerCount))
        {
            SceneManager.LoadScene(7);
        }  
        else
        {
            ClickOff();
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
        for (int k = 0; k < GameScript.PlayerCountAlive; k++) 
        {
            voteButton[k].gameObject.SetActive(true);
        }
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
