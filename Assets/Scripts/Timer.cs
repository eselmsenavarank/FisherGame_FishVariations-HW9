using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float elapsedTime = 0;
    private float targetTime = 0;
    private bool timerRunning = false;

    // Starts or resets the timer with a new target time
    public void StartTimer(float target)
    {
        targetTime = target;
        elapsedTime = 0;
        timerRunning = true;
    }

    // Call this in Update to update the timer
    public void UpdateTimer()
    {
        if (timerRunning && elapsedTime < targetTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else if (timerRunning)
        {
            timerRunning = false; // Stop the timer
            // Timer finished logic here
            Debug.Log("Timer finished! Elapsed time: " + elapsedTime);
        }
    }

    public bool IsTimerRunning()
    {
        return timerRunning;
    }

    // Get the current elapsed time
    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}
