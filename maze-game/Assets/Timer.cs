using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI uiText;
   
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    
   
    void Start()
    {
        timer = mainTimer;
    }

   void Update()
   {
    if(timer >= 0.0f && canCount)
    {
        timer -= Time.deltaTime;

        int timerMins = ((int)timer) / 60;
        int timerSeconds = ((int)timer) % 60;

        uiText.text = timerMins + ":" + timerSeconds;
    }
    else if (timer <= 0.0f && !doOnce)
    {
        canCount = false;
        doOnce = true;
        uiText.text = "0.00";
        timer = 0.0f;
    }
   }
}
