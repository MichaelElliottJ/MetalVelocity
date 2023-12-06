using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate;

    private float nextTimeToFire = 0f;

    public Transform orientation;
    public ParticleSystem muzzleFlash;

    public Animator anim;

    void Update()
    {
        nextTimeToFire += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && fireRate < nextTimeToFire)
        {
            Shoot();
            nextTimeToFire = 0;
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        anim.SetTrigger("Shoot");

        RaycastHit hit;
        if (Physics.Raycast(orientation.position, orientation.forward, out hit, range))
        {
            EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
                enemyHealth.TakeDamage(damage);
        }
    }
}
