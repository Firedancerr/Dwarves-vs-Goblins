using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Slider sliderUI;
    public Slider sliderUI2;
    public Slider sliderUI3;
    public Slider sliderUI4;
    public Toggle narrator;

    public void Start()
    {
        GameScript.Doors = (int)sliderUI.value;
        GameScript.DiscussionTime = (int)sliderUI2.value * 60;
        GameScript.GoblinNumber = (int)sliderUI3.value;
        GameScript.SeerCounter = (int)sliderUI4.value;
        GameScript.DoorsNow = GameScript.Doors;
        if (narrator.isOn == false) GameScript.HumanNarrator = 0;
        else GameScript.HumanNarrator = 1;
    }
}
