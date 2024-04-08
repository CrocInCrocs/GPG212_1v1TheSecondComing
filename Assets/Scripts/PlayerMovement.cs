using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    public PlayerController playerController;

    public Vector2 movement;
    // Start is called before the first frame update
    public void OnEnable()
    {
        playerController.InputGot += Movement();

    }

    public PlayerController.NoParameters Movement()
    {
        FixedUpdate();
        return null;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(movement.x * speed, 0f, movement.y * speed); 
    }

    public void OnDisable()
    {
        playerController.InputGot -= Movement();
    }
}
/*public KeyCode forwardKey;
   public KeyCode backKey;
   public KeyCode rightKey;
   public KeyCode leftKey;*/