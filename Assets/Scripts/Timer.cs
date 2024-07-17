using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        timeIsRunning = true;   
    }

    void Update()
    {
        if (timeIsRunning)
        {
            if(timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
        
    }

    void DisplayTime(float timeTODisplay) {
        timeTODisplay += 1;
        float minutes = Mathf.FloorToInt(timeTODisplay / 60);
        float seconds = Mathf.FloorToInt(timeTODisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes,seconds);
    }
}
