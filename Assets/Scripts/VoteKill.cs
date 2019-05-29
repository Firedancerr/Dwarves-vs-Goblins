using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoteKill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void VoteButton(int voteNumber)
    {
        GameScript.VotedOnPlayer[voteNumber]++;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
