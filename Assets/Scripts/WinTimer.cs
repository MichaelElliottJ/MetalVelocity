using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinTimer : MonoBehaviour
{
    public TextMeshProUGUI totalTime;

    void Start()
    {
        float lvlOneTime = PlayerPrefs.GetFloat("SavedTime", 0f);
        totalTime.text = "Total Time: " + FormatTime(lvlOneTime);
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
