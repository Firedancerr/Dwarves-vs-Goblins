using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInit : MonoBehaviour
{
    public static int  playerCounter = 1;
    public Text upper;
    // Start is called before the first frame update
    void Start()
    {
        upper.text = "Player " + playerCounter.ToString() + "\n" + GameScript.Players[playerCounter-1] + "\nPress the button to view your role";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
