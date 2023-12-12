using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    private Gun gun;
    public string enemyTag;
    public PlayerMovement pm;

    private bool fire;

    void Update()
    {
        if (!pm.wallrunning)
        {
            if (Input.GetMouseButtonDown(0))
            {
                fire = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                fire = false;
            }

            if (fire)
            {
                gun.Fire(enemyTag);

                if (gun.UseTap())
                {
                    fire = false;
                }
            }
        }
        
    }
}
