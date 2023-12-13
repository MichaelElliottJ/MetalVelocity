using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Eenemy : MonoBehaviour
{

    public GameObject enemyBullet;
    public AudioSource fire;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootAtPlayer", 0.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootAtPlayer()
    {
        fire.Play();
        Instantiate(enemyBullet, transform.position, Quaternion.identity);
    }

}
