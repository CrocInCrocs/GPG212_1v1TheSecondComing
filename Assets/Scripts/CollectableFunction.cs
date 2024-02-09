using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindWithTag("Player") == true)
        {
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            joint.anchor = collision.contacts[0].point;
            joint.connectedBody = collision.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
            joint.enableCollision = false;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
