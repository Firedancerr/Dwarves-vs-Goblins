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

    public void RandomDoors()
    {
        /*
        string[] Colors = new string[GameScript.PickColors.Length];
        string[] Extra = new string[GameScript.DoorExtra.Length];
        string[] Materials = new string[GameScript.PickMaterials.Length];
        string[] Mat = new string[GameScript.DoorMat.Length];
        string[] Knob = new string[GameScript.DoorKnob.Length];
        string[] Finish = new string[GameScript.DoorFinish.Length];*/
        SameType1 = Random.Range(0, 6);
        SameType2 = Random.Range(0, 6);
        SameType3 = Random.Range(0, 6);
        int j = GameScript.Doors;
        for (int i=1; i<=j;i++)
        { 
            //Kolor
        RandomedColor = Random.Range(0, GameScript.PickColors.Length);
            if (i == 2)
            {
                while (RandomedColor == GameScript.DoorsFinalGood[0])
                {
                    RandomedColor = Random.Range(0, GameScript.PickColors.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedColor == GameScript.DoorsFinalGood[0] || RandomedColor == GameScript.DoorsFinalBad[0])
                {
                    RandomedColor = Random.Range(0, GameScript.PickColors.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedColor == GameScript.DoorsFinalGood[0] || RandomedColor == GameScript.DoorsFinalBad[0] || RandomedColor == GameScript.DoorsFinalBad2[0])
                {
                    RandomedColor = Random.Range(0, GameScript.PickColors.Length);
                }
            }
            //Extra
            RandomedExtra = Random.Range(0, GameScript.DoorExtra.Length);
            if (i == 2)
            {
                while (RandomedExtra == GameScript.DoorsFinalGood[1])
                {
                    RandomedExtra = Random.Range(0, GameScript.DoorExtra.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedExtra == GameScript.DoorsFinalGood[1] || RandomedExtra == GameScript.DoorsFinalBad[1])
                {
                    RandomedExtra = Random.Range(0, GameScript.DoorExtra.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedExtra == GameScript.DoorsFinalGood[1] || RandomedExtra == GameScript.DoorsFinalBad[1] || RandomedExtra == GameScript.DoorsFinalBad2[1])
                {
                    RandomedExtra = Random.Range(0, GameScript.DoorExtra.Length);
                }
            }
        //Material
        RandomedMaterial = Random.Range(0, GameScript.PickMaterials.Length);
            if (i == 2)
            {
                while (RandomedMaterial == GameScript.DoorsFinalGood[2])
                {
                    RandomedMaterial = Random.Range(0, GameScript.PickMaterials.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedMaterial == GameScript.DoorsFinalGood[2] || RandomedMaterial == GameScript.DoorsFinalBad[2])
                {
                    RandomedMaterial = Random.Range(0, GameScript.PickMaterials.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedMaterial == GameScript.DoorsFinalGood[2] || RandomedMaterial == GameScript.DoorsFinalBad[2] || RandomedMaterial == GameScript.DoorsFinalBad2[2])
                {
                    RandomedMaterial = Random.Range(0, GameScript.PickMaterials.Length);
                }
            }
            //Mat
            RandomedMat = Random.Range(0, GameScript.DoorMat.Length);
            if (i == 2)
            {
                while (RandomedMat == GameScript.DoorsFinalGood[3])
                {
                    RandomedMat = Random.Range(0, GameScript.DoorMat.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedMat == GameScript.DoorsFinalGood[3] || RandomedMat == GameScript.DoorsFinalBad[3])
                {
                    RandomedMat = Random.Range(0, GameScript.DoorMat.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedMat == GameScript.DoorsFinalGood[3] || RandomedMat == GameScript.DoorsFinalBad[3] || RandomedMat == GameScript.DoorsFinalBad2[3])
                {
                    RandomedMat = Random.Range(0, GameScript.DoorMat.Length);
                }
            }
            //Knob
            RandomedKnob = Random.Range(0, GameScript.DoorKnob.Length);
            if (i == 2)
            {
                while (RandomedKnob == GameScript.DoorsFinalGood[4])
                {
                    RandomedKnob = Random.Range(0, GameScript.DoorKnob.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedKnob == GameScript.DoorsFinalGood[4] || RandomedKnob == GameScript.DoorsFinalBad[4])
                {
                    RandomedKnob = Random.Range(0, GameScript.DoorKnob.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedKnob == GameScript.DoorsFinalGood[4] || RandomedKnob == GameScript.DoorsFinalBad[4] || RandomedKnob == GameScript.DoorsFinalBad2[4])
                {
                    RandomedKnob = Random.Range(0, GameScript.DoorKnob.Length);
                }
            }
            //Finish
            RandomedFinish = Random.Range(0, GameScript.DoorFinish.Length);
            if (i == 2)
            {
                while (RandomedFinish == GameScript.DoorsFinalGood[5])
                {
                    RandomedFinish = Random.Range(0, GameScript.DoorFinish.Length);
                }
            }
            if (i == 3)
            {
                while (RandomedFinish == GameScript.DoorsFinalGood[5] || RandomedFinish == GameScript.DoorsFinalBad[5])
                {
                    RandomedFinish = Random.Range(0, GameScript.DoorFinish.Length);
                }
            }
            if (i == 4)
            {
                while (RandomedFinish == GameScript.DoorsFinalGood[5] || RandomedFinish == GameScript.DoorsFinalBad[5] || RandomedFinish == GameScript.DoorsFinalBad2[5])
                {
                    RandomedFinish = Random.Range(0, GameScript.DoorFinish.Length);
                }
            }
            int[] RandomDoors = {RandomedColor,RandomedExtra,RandomedMaterial, RandomedMat, RandomedKnob, RandomedFinish};
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
                GameScript.DoorsFinalBad2 = RandomDoors;
                GameScript.DoorsFinalBad2[SameType2] = GameScript.DoorsFinalBad[SameType2];
            }
            if (i == 4)
            {
                GameScript.DoorsFinalBad3 = RandomDoors;
                GameScript.DoorsFinalBad3[SameType3] = GameScript.DoorsFinalBad2[SameType3];
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
