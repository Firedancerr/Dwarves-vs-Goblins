using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class DoorVoteInit : MonoBehaviour
{
    public Button doorButton;
    public Button doorButton2;
    public Button doorButton3;
    public Button doorButton4;
    public Text doorText;
    public Text doorText2;
    public Text doorText3;
    public Text doorText4;
    public static bool door1=true;
    public static bool door2=true;
    public static bool door3=true;
    public static bool door4=true;
    public static int VoteplayerCounter = 1;
    public Text roleView;
    // Start is called before the first frame update
    void Start()
    {
        /* foreach (string player in GameScript.Players)
         {
             if (GameScript.Dead.Contains(player)) playerCounter++;
             else break;
         }*/
        VoteplayerCounter = 1;
        roleView.text = "Player " + VoteplayerCounter.ToString() + "\n" + GameScript.Players[VoteplayerCounter - 1] + "\nPress the button to begin voting";
        if (ShowDoors.txt[0] == "")
        {

            door1 = false;
        }
        else doorText.text = ShowDoors.txt[0];
        if (ShowDoors.txt[1] == "")
        {
            
            door2 = false;
        }
        else doorText2.text = ShowDoors.txt[1];
        if (ShowDoors.txt[2] == "")
        {
            
            door3 = false;
        }
        else doorText3.text = ShowDoors.txt[2];
        if (ShowDoors.txt[3] == "")
        {
            
            door4 = false;
        }
        else doorText4.text = ShowDoors.txt[3];
        doorButton.gameObject.SetActive(false);
        doorButton2.gameObject.SetActive(false);
        doorButton3.gameObject.SetActive(false);
        doorButton4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
