using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTrigger : MonoBehaviour
{
    [SerializeField] private Animator Level1WallInAnim = null;
    [SerializeField] private bool wallEneter = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Level1WallInAnim.Play("Level1WallInAnim",0,0.0f);
            gameObject.SetActive(false);
        }
    }
}
