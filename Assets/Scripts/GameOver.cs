using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        if (GameScript.EndGameResult == 1) result.text = "Dwarves win.";
        else result.text = "Goblins win.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
