using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class PostDoorVote : MonoBehaviour
{
    public Text result;
    public bool good;
    // Start is called before the first frame update
    void Start()
    {
        ShowDoors.postvote = 1;
        GameScript.DoorsNow--;
        
        if (GameScript.DoorRandoms[1] == GameScript.VotedOnDoors.Max())
        {
            good = true;
            result.text = "Correct doors have been chosen.\nProceed to the Tarot.";
        }
        else
        {
            good = false;
            result.text = "Incorrect doors have been chosen.\nVoting on who to kill will commence.";
            if (GameScript.VotedOnDoors.Max() == 1)
            {
                ShowDoors.txt1 = "";
            }
            if (GameScript.VotedOnDoors.Max() == 2)
            {
                ShowDoors.txt2 = "";
            }
            if (GameScript.VotedOnDoors.Max() == 3)
            {
                ShowDoors.txt3 = "";
            }
            if (GameScript.VotedOnDoors.Max() == 4)
            {
                ShowDoors.txt4 = "";
            }
        }
        for (int i = 0; i < GameScript.VotedOnDoors.Length; i++)
        {
            GameScript.VotedOnDoors[i] = 0;
        }


    }

    public void LoadByIndex(int sceneIndex)
    {
        if (good == true)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            SceneManager.LoadScene(10);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
