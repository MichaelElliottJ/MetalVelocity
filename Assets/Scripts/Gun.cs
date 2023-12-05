using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Animator Anim;
    public GameObject muzzleFlash;
    // Start is called before the first frame update
    void Start()
    {
        muzzleFlash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Anim.SetTrigger("Shoot");
            muzzleFlash.SetActive(true);
        }
    }
}
