using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Potato : MonoBehaviour, ICollectable
{
    public Vector3 cropScale;

    public int cropValue;
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        cropScale = gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        cropValue = 1;
        StartCoroutine(CropGrow());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
   
    public IEnumerator CropGrow()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            cropScale += gameObject.transform.localScale = new Vector3(+0.5f, +0.5f, +0.5f);
            cropValue += 1;
        }
        
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
}
