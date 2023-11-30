using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
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

    public void backToMainMenu()
    {
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
    private IEnumerator LoadSceneAsync(string levelName)
    {
        yield return new WaitForSeconds(1f);
        Application.LoadLevel(levelName);
    }
}
