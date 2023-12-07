using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;

    public AudioSource deathSound;
    public GameObject explosion;

    void Start()
    {
        explosion.SetActive(false);
    }

    public void Die()
    {
        deathSound.Play();
        explosion.SetActive(true);
        Destroy(gameObject);
    }

    
}
