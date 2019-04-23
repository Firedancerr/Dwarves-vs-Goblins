using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public static int PlayerCount;
    public static int PlayerCountAlive;
    public static int Doors;
    public static int DoorNow;
    public static int DiscussionTime;
    public static int GoblinNumber;
    public static int GoblinCounter;
    public static int SeerNumber;
    public static int SeerCounter;
    public static int HumanNarrator;
    public static int EndGameResult;
    public static List<string> Players = new List<string>();
    public static List<string> Goblin = new List<string>();
    public static List<string> Seer = new List<string>();
    public static List<string> Dwarf = new List<string>();
    public static string[] DoorsFinalGood;
    public static string[] DoorsFinalBad;
    public static string[] DoorsFinalBad2;
    public static string[] DoorsFinalBad3;
    public static string[] DoorsFinalBad4;
    public static string[] PickColors = { "red", "green", "brown", "black", "white" };
    public static string[] DoorExtra = {"none", "visor","door number"};
    public static string[] PickMaterials = {"wooden","metal"};
    public static string[] DoorMat = {"square","triangle","circle" };
    public static string[] DoorKnob = { "circle", "straight" };
    public static string[] DoorFinish = {"normal, matte, polished"};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
