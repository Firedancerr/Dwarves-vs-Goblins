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
        GameScript.TarotPick = Random.Range(1, GameScript.TarotCards);
        roleView.text = "Player " + j + "\n" + GameScript.Players[j - 1] + "\nPress the button to view your role";
        for (int k = 0; k < GameScript.VotedOnPlayer.Length; k++) GameScript.VotedOnPlayer[k] = 0;
        for (int k = 0; k < GameScript.VotedOnDoors.Length; k++) GameScript.VotedOnDoors[k] = 0;
        ShowDoors.postvote = 0;
        GameScript.DoorsNow = GameScript.Doors;
        //for (int i = 0; i < ShowDoors.txt.Length; i++) ShowDoors.txt[i] = "";
        ShowDoors.postvote = 0;
        DoorVoteInit.door1 = true;
        DoorVoteInit.door2 = true;
        DoorVoteInit.door3 = true;
        DoorVoteInit.door4 = true;
    }
    public void LoadByIndex(int sceneIndex)
    {
        if (i == 0)
        {
            if (GameScript.Goblin.Contains(GameScript.Players[j - 1]))
            {
                roleView.text = GameScript.Players[j - 1] + "\nRole : Goblin\nNext doors are " + GameScript.PickColors[GameScript.DoorsFinalGood[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.\nTarot: ";
                switch (GameScript.TarotPick)
                {
                    case 1:
                        roleView.text += "\nTarot: 0 - The Fool\n-1/+1 Door pick";
                        break;
                    case 2:
                        roleView.text += "\nTarot: 1 - The Magician\n-1/+1 Rounds";
                        break;
                    case 3:
                        roleView.text += "\nTarot: 2 - The High Priestess\nReveal goblin/+1 Door pick";
                        break;
                }
            }
            else if (GameScript.Seer.Contains(GameScript.Players[j - 1]))
            {

                roleView.text = GameScript.Players[j - 1] + "\nRole : Seer \nNext door will be/have: ";
                int randomed = Random.Range(0, 6);
                switch (randomed)
                {
                    case 1:
                        roleView.text += GameScript.PickColors[GameScript.DoorsFinalGood[0]];
                        break;
                    case 2:
                        roleView.text += GameScript.PickMaterials[GameScript.DoorsFinalGood[2]];
                        break;
                    case 3:
                        roleView.text += GameScript.DoorFinish[GameScript.DoorsFinalGood[5]];
                        break;
                    case 4:
                        roleView.text += GameScript.DoorExtra[GameScript.DoorsFinalGood[1]];
                        break;
                    case 5:
                        roleView.text += GameScript.DoorMat[GameScript.DoorsFinalGood[3]];
                        break;
                    case 6:
                        roleView.text += GameScript.DoorMat[GameScript.DoorsFinalGood[4]];
                        break;
                }
                roleView.text += "\nTarot: ";
                switch (GameScript.TarotPick)
                {
                    case 1:
                        roleView.text += "Low danger";
                        break;
                    case 2:
                        roleView.text += "Medium danger";
                        break;
                    case 3:
                        roleView.text += "Low danger";
                        break;
                }
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
