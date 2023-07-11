using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stopwatch : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool Finished;

    void Start(){

    }

    void Update(){
        if(Finished){
            return;
        }
        float t = Time.time -startTime;

        string minutes = ((int)t/60).ToString();
        string seconds = (t%60).ToString("f3");

        timerText.text = minutes + ":"+seconds;
    }
    
    public void StartTimer(){
        startTime = Time.time;
    }

    public void Finish(){
        Finished = true;
    }
}