using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour, ICollectable
{
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
       IPickedUp();
    }

    public void IPickedUp()
    {
        Destroy(gameObject);
        Debug.Log("Being collected");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
