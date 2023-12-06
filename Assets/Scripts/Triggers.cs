using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public Buttons transition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            StartCoroutine(transition.LoadSceneAsync("Win"));
        }

        if (other.gameObject.tag == "Death")
        {
            StartCoroutine(transition.LoadSceneAsync("Lose"));
        }
    }
}
