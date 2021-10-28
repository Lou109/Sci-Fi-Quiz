using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]float timeToCompleteQuestion = 30f;
    [SerializeField]float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;

    bool isAnsweringQuesion;
    float timervalue;


    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timervalue = 0;
    }

    void UpdateTimer()
    {
        timervalue -= Time.deltaTime;

        if (isAnsweringQuesion)
        {
            if(timervalue > 0)
            {
                fillFraction = timervalue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuesion = false;
                timervalue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timervalue < 0)
            {
                    fillFraction = timervalue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuesion = true;
                timervalue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}

