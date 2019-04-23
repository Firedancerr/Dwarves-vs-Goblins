using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingsStartup : MonoBehaviour
{
    public Slider sliderUI;
    public Slider sliderUI2;
    // Start is called before the first frame update
    void Start()
    {
        sliderUI.maxValue = GameScript.PlayerCount / 2;
        sliderUI2.maxValue = GameScript.PlayerCount / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
