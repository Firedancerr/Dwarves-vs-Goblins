using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Night : MonoBehaviour
{
    int i = 0;
    int j = 1;
    public Text roleView;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        roleView.text = "Player " + j + "\n" + GameScript.Players[j - 1] + "\nPress the button to view your role";
        for (int k = 0; k < GameScript.VotedOnPlayer.Length; k++) GameScript.VotedOnPlayer[k] = 0;
        for (int k = 0; k < GameScript.VotedOnDoors.Length; k++) GameScript.VotedOnDoors[k] = 0;
        ShowDoors.postvote = 0;
        
    }
    public void LoadByIndex(int sceneIndex)
    {
        if (i == 0)
        {
            if (GameScript.Goblin.Contains(GameScript.Players[j - 1]))
            {
                roleView.text = GameScript.Players[j - 1] + "\nRole : Goblin\nNext doors are " + GameScript.PickColors[GameScript.DoorsFinalGood[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            }
            else if (GameScript.Seer.Contains(GameScript.Players[j - 1]))
            {

                roleView.text = GameScript.Players[j - 1] + "\nRole : Seer \nNext door will be/have: ";

            }
            else
            {
                roleView.text = GameScript.Players[j - 1] + "\nRole : Dwarf";
            }

            i++;
            buttonText.text = "Done";
        }
        else if (j < GameScript.PlayerCountAlive)
        {
            roleView.text = "Player " + j + "\n" + GameScript.Players[j] + "\nPress the button to view your role";
            j++;
            i--;
            buttonText.text = "View Player Role";
        }
        else
        {
            SceneManager.LoadScene(6);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
