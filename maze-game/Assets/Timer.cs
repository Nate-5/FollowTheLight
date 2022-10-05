using System.Transactions;
using System.ComponentModel;
using System.Timers;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;



public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float startTime;
    private bool finished = false;
   
    void Start()
    {   //Gives us time since the app started

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        if(finished)
            return;
        
        //Store time here since timer started

        float t = Time.time - startTime;

        string minutes = ((int) t/60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds ;
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }
}
