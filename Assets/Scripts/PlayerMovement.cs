using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode forwardKey;
    public KeyCode backKey;
    public KeyCode rightKey;
    public KeyCode leftKey;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(forwardKey))
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
        }
    }
}
