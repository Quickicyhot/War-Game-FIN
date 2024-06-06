using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int myScore;
    public uint test;
    void Start()
    {
        myScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myScore = myScore + 1;
    }
}
