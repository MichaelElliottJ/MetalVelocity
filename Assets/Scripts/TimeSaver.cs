using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSaver : MonoBehaviour
{
    public TextMeshProUGUI timer;

    private void Update()
    {
        timer.text = FormatTime(Time.time);
    }

    string FormatTime(float time)
    {
        int intTime = (int)time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string timeText = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
        return timeText;
    }
}
