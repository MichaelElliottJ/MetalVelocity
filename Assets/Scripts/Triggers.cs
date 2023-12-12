using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public Buttons transition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LevelOneWin")
        {
            StartCoroutine(transition.LoadSceneAsync("Level2"));
        }

        if (other.gameObject.tag == "LevelTwoWin")
        {
            StartCoroutine(transition.LoadSceneAsync("Level3"));
        }

        if (other.gameObject.tag == "LevelThreeWin")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            StartCoroutine(transition.LoadSceneAsync("Win"));
        }

        if (other.gameObject.tag == "Death")
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
