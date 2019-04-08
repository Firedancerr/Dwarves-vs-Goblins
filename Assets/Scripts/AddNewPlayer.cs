using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNewPlayer : MonoBehaviour
{
    public GameObject PopUp;
    public Text PlayerList;
    public Text PlayerName;

    private void Start()
    {
        PopUp.SetActive(false);
    }
    public void Clicked(int popupHide)
    {
        if (popupHide == 0)
        {
            PopUp.SetActive(true);
        }
        if (popupHide == 1)
        {
            PopUp.SetActive(false);
            GameScript.PlayerCount++;
            PlayerList.text = PlayerList.text + "\n" + PlayerName.text + " " + GameScript.PlayerCount.ToString();
            GameScript.Players.Add(PlayerName.text);
            PlayerName.text = "";
        }
    }
}
