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
        while (GameScript.GoblinCounter < GameScript.GoblinNumber)
        {
            int randomRole = Random.Range(0, GameScript.Players.Count);
            GameScript.Goblin.Add(GameScript.Players[randomRole]);
            GameScript.GoblinCounter++;
        }
        while (GameScript.SeerCounter < GameScript.SeerNumber)
        {
            int randomRole = Random.Range(0, GameScript.Players.Count);
            while (GameScript.Goblin.Contains(GameScript.Players[randomRole]))
                {
                randomRole = Random.Range(0, GameScript.Players.Count);
                }
            GameScript.Seer.Add(GameScript.Players[randomRole]);
            GameScript.SeerCounter++;
        }
        foreach (string player in GameScript.Players)
        {
            if (!(GameScript.Goblin.Contains(player)) && !(GameScript.Seer.Contains(player)))
            {
                GameScript.Dwarf.Add(player);
            }
        }

        upper.text = "Player " + playerCounter.ToString() + "\n" + GameScript.Players[playerCounter-1] + "\nPress the button to view your role";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
