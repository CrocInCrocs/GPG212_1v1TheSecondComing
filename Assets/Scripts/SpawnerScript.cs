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
    
    // Start is called before the first frame update
   
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlantSpawner(int plantToSpawn)
    {
        plantToSpawn = Random.Range(0, 4);

        Instantiate(plants[plantToSpawn], new Vector3(0, 0, 0), Quaternion.identity);
    }
}
