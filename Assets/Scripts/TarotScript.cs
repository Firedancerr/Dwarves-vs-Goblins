using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TarotScript : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        switch (GameScript.TarotPick)
        {
            case 1:
                text.text = "Card 0 - The Fool\n";
                if (GameScript.TarotRotation == 0)
                {
                    text.text += "-1 Door pick";
                    GameScript.Doors--;
                    GameScript.DoorsNow--;
                }
                else
                {
                    text.text += "+1 Door pick";
                    GameScript.Doors++;
                    GameScript.DoorsNow++;
                }
                break;
            case 2:
                text.text = "Card 1 - The Magician\n";
                if (GameScript.TarotRotation == 0)
                {
                    text.text += "-1 Round";
                    GameScript.Rounds--;
                }
                else
                {
                    text.text += "+1 Round";
                    GameScript.Rounds++;
                }
                break;
            case 3:
                text.text = "Card 2 - The High Priestess\n";
                if (GameScript.TarotRotation == 0)
                {
                    text.text += "A goblin has been revealed: "+GameScript.Goblin[0];
                }
                else
                {
                    text.text += "+1 Door pick";
                    GameScript.Doors++;
                    GameScript.DoorsNow++;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
