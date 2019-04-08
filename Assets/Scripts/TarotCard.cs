using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotCard : MonoBehaviour
{
    // Start is called before the first frame update
    public Button card;
    public Button b1;
    public Button b2;
    void Start()
    {
        card.gameObject.SetActive(false);
        int x = Random.Range(0, 2);
        if (x==0)
        {

        }
        else
        {
            card.gameObject.transform.Rotate(new Vector3(0, 0, 180));
        }
    }

    public void LoadByIndex(int sceneIndex)
    {
        card.gameObject.SetActive(true);
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
