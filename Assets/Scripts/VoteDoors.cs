using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteDoors : MonoBehaviour
{
    int i = 0;
    public Text roleView;
    public Text buttonText;
    private int playerCounter = 1;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void LoadByIndex(int sceneIndex)
    {
        if (i == 0)
        {
            roleView.text = GameScript.Players[playerCounter - 1] + "\nRole : " + Random.Range(0, 4);
            i++;
            buttonText.text = "Done";
        }
        else if (playerCounter < GameScript.PlayerCount)
        {
            roleView.text = "Player " + playerCounter.ToString() + "\n" + GameScript.Players[playerCounter] + "\nPress the button to begin voting";
            playerCounter++;
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
