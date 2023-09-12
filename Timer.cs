using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour 
{
    [SerializeField] TextMeshProUGUI Countdowntext;
    [SerializeField] float remainingtime;
     void Update()
    {
        remainingtime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        Countdowntext.text = string.Format("{00:00}:{1:00)", minutes, seconds);
     if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;
        }
     else if (remainingtime < 0) 
        {
            remainingtime = 0;
            // Gameover();
            Countdowntext.color = Color.red;
        }
    }




        






}
