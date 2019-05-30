using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;


public class PostKillVote : MonoBehaviour
{
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        string toDie = GameScript.Players[GameScript.VotedOnPlayer.ToList().IndexOf(GameScript.VotedOnPlayer.Max())-1];
        result.text =  "Player " + toDie + "has been chosen to die.";
        GameScript.Dead.Add(toDie);
        if (GameScript.Goblin.Contains(toDie))
        {
            GameScript.Goblin.Remove(toDie);
            GameScript.Players.Remove(toDie);
            GameScript.PlayerCountAlive--;
            result.text += "\nHe was a goblin!";
            if (GameScript.Goblin.Count==0)
            {
                result.text += "\nGame Over, goblins are dead!";
                GameScript.EndGameResult = 1;
            }
        }

        else if (GameScript.Seer.Contains(toDie))
        {
            GameScript.Seer.Remove(toDie);
            GameScript.Players.Remove(toDie);
            GameScript.PlayerCountAlive--;
            result.text += "\nHe was a seer!";
            if (GameScript.Seer.Count == 0 && GameScript.Dwarf.Count==0)
            {
                result.text += "\nGame Over, dwarves are dead!";
                GameScript.EndGameResult = 2;
            }
        }

        else if (GameScript.Dwarf.Contains(toDie))
        {
            GameScript.Dwarf.Remove(toDie);
            GameScript.Players.Remove(toDie);
            GameScript.PlayerCountAlive--;
            result.text += "\nHe was a dwarf!";
            if (GameScript.Seer.Count == 0 && GameScript.Dwarf.Count == 0)
            {
                result.text += "\nGame Over, dwarves are dead!";
                GameScript.EndGameResult = 2;
            }
        }
    }
    public void ProceedButton(int scene)
    {
        if (GameScript.EndGameResult == 0)
        {
            SceneManager.LoadScene(6);
        }
        else SceneManager.LoadScene(13);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
