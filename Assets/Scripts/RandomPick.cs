using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPick : MonoBehaviour
{
    int RandomedColor;
    int RandomedExtra;
    int RandomedMaterial;
    int RandomedMat;
    int RandomedKnob;
    int RandomedFinish;
    int SameType1;
    int SameType2;
    int SameType3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RandomDoors(int j)
    {
        string[] Colors = new string[GameScript.PickColors.Length];
        string[] Extra = new string[GameScript.DoorExtra.Length];
        string[] Materials = new string[GameScript.PickMaterials.Length];
        string[] Mat = new string[GameScript.DoorMat.Length];
        string[] Knob = new string[GameScript.DoorKnob.Length];
        string[] Finish = new string[GameScript.DoorFinish.Length];
        SameType1 = Random.Range(0, 7);
        SameType2 = Random.Range(0, 7);
        SameType3 = Random.Range(0, 7);
        for (int i=1; i<=j;i++)
        { 
        RandomedColor = Random.Range(0, Colors.Length);
        RandomedExtra = Random.Range(0, Extra.Length);
        RandomedMaterial = Random.Range(0, Materials.Length);
        RandomedMat = Random.Range(0, Mat.Length);
        RandomedKnob = Random.Range(0, Mat.Length);
        RandomedFinish = Random.Range(0, Finish.Length);
        string[] RandomDoors = {RandomedColor.ToString(),RandomedExtra.ToString(),RandomedMaterial.ToString(), RandomedMat.ToString(), RandomedKnob.ToString(), RandomedFinish.ToString() };
            if (i==1)
            {
                GameScript.DoorsFinalGood = RandomDoors;
            }
            if (i == 2)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType1] = GameScript.DoorsFinalGood[SameType1];
            }
            if (i == 3)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType2] = GameScript.DoorsFinalGood[SameType2];
            }
            if (i == 4)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType3] = GameScript.DoorsFinalGood[SameType3];
            }

        }
    }
    /*
    public void Random3Doors()
    {
        SameType1 = Random.Range(0, 7);
        SameType2 = Random.Range(0, 7);
        for (int i = 1; i <= 3; i++)
        {
            RandomedColor = Random.Range(0, 6);
            RandomedExtra = Random.Range(0, 5);
            RandomedMaterial = Random.Range(0, 5);
            RandomedMat = Random.Range(0, 5);
            RandomedKnob = Random.Range(0, 5);
            RandomedFinish = Random.Range(0, 5);
            string[] RandomDoors = { RandomedColor.ToString(), RandomedExtra.ToString(), RandomedMaterial.ToString(), RandomedMat.ToString(), RandomedKnob.ToString(), RandomedFinish.ToString() };
            if (i == 1)
            {
                GameScript.DoorsFinalGood = RandomDoors;
            }
            if (i == 2)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType1] = GameScript.DoorsFinalGood[SameType1];
            }
            if (i == 3)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType2] = GameScript.DoorsFinalBad[SameType1];
            }

        }
    }
    public void Random4Doors()
    {
        SameType1 = Random.Range(0, 7);
        SameType2 = Random.Range(0, 7);
        SameType3 = Random.Range(0, 7);
        for (int i = 1; i <= 4; i++)
        {
            RandomedColor = Random.Range(0, 6);
            RandomedExtra = Random.Range(0, 5);
            RandomedMaterial = Random.Range(0, 5);
            RandomedMat = Random.Range(0, 5);
            RandomedKnob = Random.Range(0, 5);
            RandomedFinish = Random.Range(0, 5);
            string[] RandomDoors = { RandomedColor.ToString(), RandomedExtra.ToString(), RandomedMaterial.ToString(), RandomedMat.ToString(), RandomedKnob.ToString(), RandomedFinish.ToString() };
            if (i == 1)
            {
                GameScript.DoorsFinalGood = RandomDoors;
            }
            if (i == 2)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType1] = GameScript.DoorsFinalGood[SameType1];
            }
            if (i == 3)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType2] = GameScript.DoorsFinalGood[SameType2];
            }
            if (i == 4)
            {
                GameScript.DoorsFinalBad = RandomDoors;
                GameScript.DoorsFinalBad[SameType3] = GameScript.DoorsFinalGood[SameType3];
            }

        }
    }*/



    // Update is called once per frame
    void Update()
    {
        
    }
}
