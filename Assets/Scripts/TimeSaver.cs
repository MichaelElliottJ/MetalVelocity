using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeSaver : MonoBehaviour
{
    public TextMeshProUGUI timer;
    string sceneName;

    bool isCounting = false;

    private void Update()
    {
        sceneName = SceneManager.GetActiveScene().ToString();

        if (sceneName == "Level1" || sceneName == "Level2" || sceneName == "Level3")
            isCounting = true;
        
        else
            isCounting = false;

        if (isCounting)
        {
            float currentTime = Time.time;
            timer.text = FormatTime(currentTime);

            SaveTime(currentTime);
        }
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
