﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Slider sliderUI;
    public Slider sliderUI2;
    public Slider sliderUI3;
    public Slider sliderUI4;
    public Slider sliderUI5;
    public Toggle narrator;

    public void Start()
    {
        GameScript.TarotPick = Random.Range(1, GameScript.TarotCards);
        GameScript.Doors = (int)sliderUI.value;
        GameScript.DiscussionTime = (int)sliderUI2.value * 60;
        GameScript.GoblinNumber = (int)sliderUI3.value;
        GameScript.SeerNumber = (int)sliderUI4.value;
        GameScript.Rounds = (int)sliderUI5.value;
        GameScript.GoblinCounter = 0;
        GameScript.SeerCounter = 0;
        GameScript.DwarfNumber = GameScript.PlayerCount - GameScript.GoblinNumber - GameScript.SeerNumber;
        GameScript.DoorsNow = GameScript.Doors;
        GameScript.RoundNow = 0;
        if (narrator.isOn == false) GameScript.HumanNarrator = 0;
        else GameScript.HumanNarrator = 1;
    }
}
