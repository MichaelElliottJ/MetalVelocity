using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Canvas;

    public TimeSaver ts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //ts.currentTime = 0;
        StartCoroutine(LoadSceneAsync("Level1"));
    }  
    
    public void goToHelp()
    {
        StartCoroutine(LoadSceneAsync("Help"));
    }

    public void goToCredits()
    {
        StartCoroutine(LoadSceneAsync("Credits"));
    }
    public void backToMainMenuFromUI()
    {
        StartCoroutine(LoadSceneAsync("MainMenu"));
    }
    public void backToMainMenuFromLevels()
    {
        Time.timeScale = 0.5f;
        Canvas.gameObject.SetActive (false);

        StartCoroutine(LoadSceneAsync("MainMenu"));
    }

    public void goToOptions()
    {
        StartCoroutine(LoadSceneAsync("Options"));
    }

    public void goToSandbox()
    {
        StartCoroutine(LoadSceneAsync("Sandbox"));
    }

    public void closeGame()
    {
        Application.Quit();
    }
   
    public IEnumerator LoadSceneAsync(string levelName)
    {
        yield return new WaitForSeconds(0.3f);
        Application.LoadLevel(levelName);
    }
}
