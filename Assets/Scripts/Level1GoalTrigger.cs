using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1GoalTrigger : MonoBehaviour
{
    [SerializeField] public Animator Level1GoalTriggerAnim = null;
    [SerializeField] private bool goalEnter = false;
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
            Level1GoalTriggerAnim.Play("Level1GoalTriggerAnim",0,0.0f);
            gameObject.SetActive(false);
        }
    }
}
