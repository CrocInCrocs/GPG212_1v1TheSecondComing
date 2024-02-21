using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public List<GameObject> plants;
    
    public delegate void NoParameters();

    public event NoParameters PickedUp;

    public int plantToSpawn;
    // Start is called before the first frame update
   void OnEnable()
   {
       PlantSpawner();
       
   }


   // Update is called once per frame
    void Update()
    {
       
    }

    public void PlantSpawner()
    {
        plantToSpawn = Random.Range(0, 2);
        Debug.Log("${plantToSpawn}"); 

        Instantiate(plants[plantToSpawn],transform.position,Quaternion.identity, gameObject.transform.parent);
    }
}
