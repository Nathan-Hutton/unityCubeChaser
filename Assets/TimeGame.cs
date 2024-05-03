using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartTime;
    bool roundStarted;
    int timeToGuess;
    void Start()
    {
        print("Press the spacebar when you think the alloted time is up");
        Invoke("SetNewRandomTime", 3);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted)
            HanldeUserAttempt();
    }

    void HanldeUserAttempt()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        print(Mathf.Abs(timeToGuess - playerWaitTime) + " seconds off");
        Invoke("SetNewRandomTime", 3);
    }

    void SetNewRandomTime()
    {
        roundStartTime = Time.time;
        timeToGuess = Random.Range(5, 21);
        roundStarted = true;
        print(timeToGuess + " seconds");
    }
}
