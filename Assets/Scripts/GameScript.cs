﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public static int PlayerCount = 0;
    public static int PlayerCountAlive = 0;
    public static int Rounds;
    public static int RoundNow;
    public static int Doors;
    public static int DoorsNow;
    public static int DiscussionTime;
    public static int GoblinNumber;
    public static int GoblinCounter;
    public static int SeerNumber;
    public static int SeerCounter;
    public static int HumanNarrator;
    public static int DwarfNumber;
    public static int DwarfCounter;
    public static int EndGameResult=0;
    public static List<string> Players = new List<string>();
    public static List<string> Goblin = new List<string>();
    public static List<string> Seer = new List<string>();
    public static List<string> Dwarf = new List<string>();
    public static List<string> Dead = new List<string>();
    public static int[] VotedOnPlayer = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static int[] VotedOnDoors = { 0, 0, 0, 0, 0 };
    public static int GoodDoors;
    public static int[] DoorRandoms = new int[5];
    public static int TarotPick;
    public static int TarotCards = 3;
    public static int TarotRotation;
    public static int[] DoorsFinalGood;
    public static int[] DoorsFinalBad;
    public static int[] DoorsFinalBad2;
    public static int[] DoorsFinalBad3;
    public static string[] PickColors = { "red", "green", "brown", "black", "white"};
    public static string[] DoorExtra = {"hole", "visor","door number","nameplate"};
    public static string[] PickMaterials = {"wooden","metal","glass","plastic"};
    public static string[] DoorMat = {"square","triangle","circle","tattered"};
    public static string[] DoorKnob = { "circle", "simple","square","weird"};
    public static string[] DoorFinish = {"normal", "dirty", "polished","broken"};


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
