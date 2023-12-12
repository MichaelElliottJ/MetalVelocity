using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeSaver : MonoBehaviour
{
    public TextMeshProUGUI timer;

    bool isCounting = false;

    private void Update()
    {
        Scene sceneName = SceneManager.GetActiveScene();

        if (sceneName.name == "Level1" || sceneName.name == "Level2" || sceneName.name == "Level3")
            isCounting = true;
        
        else
            isCounting = false;

        if (isCounting)
        {
            StartTimer();
        }
    }

    void StartTimer()
    {
        float currentTime = Time.time;
        timer.text = FormatTime(currentTime);

        SaveTime(currentTime);
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

    void SaveTime(float time)
    {
        PlayerPrefs.SetFloat("SavedTime", time);
        PlayerPrefs.Save();
    }
}
