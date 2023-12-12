using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header ("Gun Stuff")]
    public float damage;
    public float fireRate;
    public float fireDistance;
    public Transform bulletPoint;

    public ParticleSystem muzzleFlash;
    public Animator anim;

    private bool fireCooldown;
    private RaycastHit hit;
    
    public void Fire(string enemyTag)
    {
        if (fireCooldown) return;

        Ray ray = new Ray();
        ray.origin = bulletPoint.position;
        ray.direction = bulletPoint.TransformDirection(Vector3.forward);

        muzzleFlash.Play();
        anim.SetTrigger("Shoot");

        Debug.DrawRay(ray.origin, ray.direction * fireDistance, Color.blue);

        if (Physics.Raycast(ray, out hit, fireDistance))
        {
            if (hit.collider.CompareTag(enemyTag))
            {
                EnemyHealth eHealth = hit.collider.GetComponent<EnemyHealth>();
                eHealth.Die();
            }
        }

        fireCooldown = true;
        StartCoroutine(ResetCooldown());
    }

    private IEnumerator ResetCooldown()
    {
        yield return new WaitForSeconds(fireRate);
        fireCooldown = false;
    }

    public bool UseTap()
    {
        return fireRate == 0;
    }
}
