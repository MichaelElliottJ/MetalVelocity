using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Eenemy : MonoBehaviour
{

    public GameObject enemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootAtPlayer", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootAtPlayer()
    {

        Instantiate(enemyBullet, transform.position, Quaternion.identity);

    }

}
