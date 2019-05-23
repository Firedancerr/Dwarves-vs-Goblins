using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickedRole : MonoBehaviour
{
    int i = 0;
    public Text roleView;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadByIndex(int sceneIndex)
    {
        if (i==0)
        {
            if (GameScript.Goblin.Contains(GameScript.Players[PlayerInit.playerCounter - 1]))
            {
                roleView.text = GameScript.Players[PlayerInit.playerCounter - 1] + "\nRole : Goblin";
            }
            else if (GameScript.Seer.Contains(GameScript.Players[PlayerInit.playerCounter - 1]))
            {

                roleView.text = GameScript.Players[PlayerInit.playerCounter - 1] + "\nRole : Seer \nNext door will be/have: ";

            }
                else
            {
                roleView.text = GameScript.Players[PlayerInit.playerCounter - 1] + "\nRole : Dwarf";
            }
                
            i++;
            buttonText.text = "Done";
        }
        else if (PlayerInit.playerCounter<GameScript.PlayerCount)
        {
            roleView.text = "Player " + PlayerInit.playerCounter.ToString() + "\n" + GameScript.Players[PlayerInit.playerCounter] + "\nPress the button to view your role";
            PlayerInit.playerCounter++;
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
