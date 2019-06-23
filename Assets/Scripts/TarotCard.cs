using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotCard : MonoBehaviour
{
    // Start is called before the first frame update
    public Button card;
    public Button card2;
    public Button card3;
    public Button b1;
    public Button b2;
    void Start()
    {
        card.gameObject.SetActive(false);
        card2.gameObject.SetActive(false);
        card3.gameObject.SetActive(false);
        int x = Random.Range(0, 2);
        switch (GameScript.TarotPick)
        {
            case 1:
                
                if (x == 0)
                {
                    GameScript.TarotRotation = 0;
                }
                else
                {
                    GameScript.TarotRotation = 1;
                    card.gameObject.transform.Rotate(new Vector3(0, 0, 180));
                }
                break;

            case 2:
                if (x == 0)
                {
                    GameScript.TarotRotation = 0;
                }
                else
                {
                    GameScript.TarotRotation = 1;
                    card.gameObject.transform.Rotate(new Vector3(0, 0, 180));
                }
                break;

            case 3:
                if (x == 0)
                {
                    GameScript.TarotRotation = 0;
                }
                else
                {
                    GameScript.TarotRotation = 1;
                    card.gameObject.transform.Rotate(new Vector3(0, 0, 180));
                }
                break;
        }

    }

    public void LoadByIndex(int sceneIndex)
    {
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        switch (GameScript.TarotPick)
        {
            case 1:
                card.gameObject.SetActive(true);
                break;
            case 2:
                card2.gameObject.SetActive(true);
                break;
            case 3:
                card3.gameObject.SetActive(true);
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
