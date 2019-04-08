using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickedRole : MonoBehaviour
{
    int i = 0;
    public Text roleView;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadByIndex(int sceneIndex)
    {
        if (i==0)
        {
            roleView.text = GameScript.Players[PlayerInit.playerCounter - 1] + "\nRole : " + Random.Range(0, 4);
            i++;
        }
        else if (PlayerInit.playerCounter<GameScript.PlayerCount)
        {
            roleView.text = "Player " + PlayerInit.playerCounter.ToString() + "\n" + GameScript.Players[PlayerInit.playerCounter - 1] + "\nPress the button to view your role";
            PlayerInit.playerCounter++;
            i--;
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
