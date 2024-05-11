using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Potato : MonoBehaviour, ICollectable
{

    public int cropValue;
    public Spawner spawner;
    public PlayerModel player;
    private void OnEnable()
    {
        spawner = new Spawner();
        spawner.Spawned += SpawnerOnSpawned;
      
    }

    private void SpawnerOnSpawned()
    {
        //Sets size and value for the crop on spawn
        gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        cropValue = 1;
        //Starts the continuous growth for the crop
        StartCoroutine(CropGrow());
    }

    public IEnumerator CropGrow()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            gameObject.transform.localScale += new Vector3(+0.5f, +0.5f, +0.5f);
            cropValue += 1;
        }
        
    }

    public void IPickedUp()
    {
        player.playerScore =+ cropValue;
        Destroy(gameObject);
        Debug.Log("Being collected");
        spawner.PlantSpawner();
        
    }

    private void OnDisable()
    {
        spawner.Spawned -= SpawnerOnSpawned;
    }
}
