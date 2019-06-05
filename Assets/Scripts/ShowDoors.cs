using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class ShowDoors : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public static int postvote = 0;
    public static string[] txt = { "", "", "", "" };
    public static string goodtxt;

    // Start is called before the first frame update
    void Start()
    {
        

            GameScript.GoodDoors = 1;

        Text[] texts = new Text[4];
        texts[0] = text1;
        texts[1] = text2;
        texts[2] = text3;
        texts[3] = text4;
        Random rnd = new Random();
        if (postvote == 0) { 
        if (GameScript.DoorsNow == 1)
        {
            txt[0] = GameScript.PickColors[GameScript.DoorsFinalGood[0]] +" "+ GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
                text1.text = txt[0];
                goodtxt = txt[0];
                text2.text = txt[1];
                text3.text = txt[2];
                text4.text = txt[3];
            }
        if (GameScript.DoorsNow == 2)
        {
            txt[0] = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt[1] = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
                goodtxt = txt[0];
                Reshuffle(txt);
                text1.text = txt[0];
                
                text2.text = txt[1];
                text3.text = txt[2];
                text4.text = txt[3];
            }
        if (GameScript.DoorsNow == 3)
        {
            txt[0] = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt[1] = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
            txt[2] = GameScript.PickColors[GameScript.DoorsFinalBad2[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad2[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad2[5]] + "doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad2[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad2[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad2[4]] + " doorknob.";
                goodtxt = txt[0];
                Reshuffle(txt);
                text1.text = txt[0];
                text2.text = txt[1];
                text3.text = txt[2];
                text4.text = txt[3];
            }
        if (GameScript.DoorsNow == 4)
        {
            txt[0] = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt[1] = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
            txt[2] = GameScript.PickColors[GameScript.DoorsFinalBad2[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad2[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad2[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad2[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad2[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad2[4]] + " doorknob.";
            txt[3] = GameScript.PickColors[GameScript.DoorsFinalBad3[0]] + " " + GameScript.PickMaterials[GameScript.DoorsFinalBad3[2]] + " " + GameScript.DoorFinish[GameScript.DoorsFinalBad3[5]] + " doors with " + GameScript.DoorExtra[GameScript.DoorsFinalBad3[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad3[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad3[4]] + " doorknob.";
                goodtxt = txt[0];
                Reshuffle(txt);
            text1.text = txt[0];
                text2.text = txt[1];
            text3.text = txt[2];
            text4.text = txt[3];
        }
        }
        else
        {
            text1.text = txt[0];
            text2.text = txt[1];
            text3.text = txt[2];
            text4.text = txt[3];
        }

    }

    void Reshuffle(string[] texts)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < texts.Length; t++)
        {
            
            string tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            GameScript.DoorRandoms[t + 1] = r;
            if (t==0)
            {
                GameScript.GoodDoors = r;
            }
            texts[t] = texts[r];
            texts[r] = tmp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
