using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScirpt : MonoBehaviour
{
    Vector3 playerPos;
    public float speed;

    void Start()
    {
        playerPos = GameObject.Find("Player").transform.position;
        Destroy(gameObject, 2);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
