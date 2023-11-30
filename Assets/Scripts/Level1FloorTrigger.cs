using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1FloorTrigger : MonoBehaviour
{
    [SerializeField] public Animator StartAnim = null;
    [SerializeField] private bool enter = false;
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
            StartAnim.Play("StartAnim",0,0.0f);
            gameObject.SetActive(false);
        }
    }
}
