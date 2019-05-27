using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class DoorVoteInit : MonoBehaviour
{
    public static Button doorButton;
    public static Button doorButton2;
    public static Button doorButton3;
    public static Button doorButton4;
    public Text doorText;
    public Text doorText2;
    public Text doorText3;
    public Text doorText4;
    public static bool door1=true;
    public static bool door2=true;
    public static bool door3=true;
    public static bool door4=true;
    public static int playerCounter = 1;
    public Text roleView;
    // Start is called before the first frame update
    void Start()
    {
        foreach (string player in GameScript.Players)
        {
            if (GameScript.Dead.Contains(player)) playerCounter++;
            else break;
        }
        roleView.text = "Player " + playerCounter.ToString() + "\n" + GameScript.Players[playerCounter] + "\nPress the button to begin voting";
        if (ShowDoors.txt1 == "")
        {
            doorButton.gameObject.SetActive(false);
            door1 = false;
        }
        else doorText.text = ShowDoors.txt1;
        if (ShowDoors.txt2 == "")
        {
            doorButton2.gameObject.SetActive(false);
            door2 = false;
        }
        else doorText2.text = ShowDoors.txt2;
        if (ShowDoors.txt3 == "")
        {
            doorButton3.gameObject.SetActive(false);
            door3 = false;
        }
        else doorText3.text = ShowDoors.txt3;
        if (ShowDoors.txt4 == "")
        {
            doorButton4.gameObject.SetActive(false);
            door4 = false;
        }
        else doorText4.text = ShowDoors.txt4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
