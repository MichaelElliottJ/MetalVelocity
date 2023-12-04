using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Canvas;
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

    public void closeGame()
    {
        Application.Quit();
    }
    public IEnumerator LoadSceneAsync(string levelName)
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel(levelName);
    }
}
