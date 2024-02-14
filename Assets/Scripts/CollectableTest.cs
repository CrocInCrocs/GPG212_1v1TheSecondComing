using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableTest : MonoBehaviour, ICollectable 
{
    // Start is called before the first frame update
    void Start()
    {
        
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
