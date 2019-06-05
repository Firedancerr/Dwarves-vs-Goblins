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
        

        if (ShowDoors.goodtxt == ShowDoors.txt[GameScript.VotedOnDoors.ToList().IndexOf(GameScript.VotedOnDoors.Max())-1])
        {
            good = true;
            result.text = "Correct doors have been chosen.\nProceed to the Tarot.\n";
        }
        else
        {
            good = false;
            result.text = "Incorrect doors have been chosen.\nVoting on who to kill will commence.\n";
            ShowDoors.txt[GameScript.VotedOnDoors.ToList().IndexOf(GameScript.VotedOnDoors.Max())-1] = "";
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
