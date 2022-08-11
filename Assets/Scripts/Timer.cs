using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTextFinish;

    public TextMeshProUGUI timerTextTotal;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString("f0");
        string seconds = (t % 60).ToString("f1");

        timerText.text = minutes + ":" + seconds;
        timerTextFinish.text = minutes + ":" + seconds;
        timerTextTotal.text = minutes + ":" + seconds;


    }
}
