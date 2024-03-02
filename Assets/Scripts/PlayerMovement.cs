using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode forwardKey;
    public KeyCode backKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    
    public float speed = 1.0f;
    public Rigidbody rb;

    public PlayerController playerController;
    // Start is called before the first frame update
    private void OnEnable()
    {
        playerController.InputGot += Movement;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(forwardKey))
        {
            transform.Translate(Vector3.forward * speed);
        }
         if(Input.GetKey(backKey))
        {
            transform.Translate(Vector3.forward * -speed);
        }
         if(Input.GetKey(rightKey))
        {
            transform.Translate(Vector3.right * speed);
        }
         if(Input.GetKey(leftKey))
        {
            transform.Translate(Vector3.left * speed);
        }*/
    }

    public void Movement()
    {
        rb.AddForce(0f,10f,0f);
    }

    public void OnDisable()
    {
        playerController.InputGot -= Movement;
    }
}
