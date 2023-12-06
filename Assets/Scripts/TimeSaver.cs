using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSaver : MonoBehaviour
{
    public static TimeSaver LT { get; private set; }
    public string lvl1Time;
    public string lvl2Time;
    public int minNum1;
    public int minNum2;
    public int secNum1;
    public int secNum2;

    void Awake()
    {
        if (LT == null)
        {
            LT = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
}
