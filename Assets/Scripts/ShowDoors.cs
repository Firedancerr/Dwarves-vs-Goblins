using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDoors : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    
    public string txt1;
    public string txt2;
    public string txt3;
    public string txt4;

    
    // Start is called before the first frame update
    void Start()
    {
        Text[] texts = new Text[4];
        texts[0] = text1;
        texts[1] = text2;
        texts[2] = text3;
        texts[3] = text4;
        
        if (GameScript.DoorsNow == 1)
        {
            txt1 = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
        }
        if (GameScript.DoorsNow == 2)
        {
            txt1 = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
            reshuffle(texts);
            texts[0].text = txt1;
            texts[1].text = txt2;
        }
        if (GameScript.DoorsNow == 3)
        {
            txt1 = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad2[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad2[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad2[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad2[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad2[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad2[4]] + " doorknob.";
            reshuffle(texts);
            texts[0].text = txt1;
            texts[1].text = txt2;
            texts[2].text = txt3;
        }
        if (GameScript.DoorsNow == 4)
        {
            txt1 = GameScript.PickColors[GameScript.DoorsFinalGood[0]] + GameScript.PickMaterials[GameScript.DoorsFinalGood[2]] + GameScript.DoorFinish[GameScript.DoorsFinalGood[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalGood[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalGood[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalGood[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad2[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad2[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad2[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad2[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad2[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad2[4]] + " doorknob.";
            txt2 = GameScript.PickColors[GameScript.DoorsFinalBad3[0]] + GameScript.PickMaterials[GameScript.DoorsFinalBad3[2]] + GameScript.DoorFinish[GameScript.DoorsFinalBad3[5]] + "doors with" + GameScript.DoorExtra[GameScript.DoorsFinalBad3[1]] + ", " + GameScript.DoorMat[GameScript.DoorsFinalBad3[3]] + " doormat and " + GameScript.DoorKnob[GameScript.DoorsFinalBad3[4]] + " doorknob.";
            reshuffle(texts);
            texts[0].text = txt1;
            texts[1].text = txt2;
            texts[2].text = txt3;
            texts[3].text = txt4;
        }
    }

    void reshuffle(Text[] texts)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < texts.Length; t++)
        {
            Text tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
