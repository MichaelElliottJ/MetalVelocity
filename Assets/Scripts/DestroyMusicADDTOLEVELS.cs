using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusicADDTOLEVELS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.FindGameObjectsWithTag("GameMusic")[0]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
