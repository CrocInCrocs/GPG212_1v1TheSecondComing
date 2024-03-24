using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Potato>())
        {
            collision.gameObject.GetComponent<ICollectable>().IPickedUp();
            Debug.Log("Trying to collect");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
