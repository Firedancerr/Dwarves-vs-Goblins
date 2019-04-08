using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public static int PlayerCount;
    public static int PlayerCountAlive;
    public static List<string> Players;
    public static string[] DoorsFinal;
    public static string[] PickColors = { "red", "green", "brown", "black", "white" };
    public static string[] DoorExtra = {"none", "visor","door number"};
    public static string[] PickMaterials = {"wooden","metal"};
    public static string[] DoorMat = {"square","triangle","circle" };
    public static string[] DoorKnob = { "circle", "straight" };
    public static string[] DoorFinish = {"none"};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
