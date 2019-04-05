using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GameObject PopUp;
    public Text helpText;

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
        }

    }
}
