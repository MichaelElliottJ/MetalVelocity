using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    Buttons Buttons;
    public GameObject Canvas;
    bool isMuted = false;
    bool IsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPaused ==true)
            {
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive (false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                IsPaused = false;
            }else
                {
                    Time.timeScale = 0.0f;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    Canvas.gameObject.SetActive (true);
                    IsPaused = true;
                }
            
        }
    }
    
    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive (false);

    }
    public void MuteButton()
    {
        
    
        AudioListener.volume = 0;
    
    }
    public void UnMuteButton()
    {
        AudioListener.volume = 0.5f;
    }
}

