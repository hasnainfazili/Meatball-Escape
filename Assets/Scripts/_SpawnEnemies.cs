using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpawnEnemies : MonoBehaviour
{
    public GameObject[] Fork;
    public float[] x;
    public GameObject trigger;
    GameObject forkSpawned;
    GameObject LastTrigger;
    GameObject LastSpawned;
    public Vector2 spawnPosition;
    

    private void Start()
    {
        LastTrigger = trigger;
    }

    public void GenerateFork(Vector2 playerPosition)
    {
        if(spawnPosition == Vector2.zero)
        {
            spawnPosition = new Vector2(x[Random.Range(0,2)], playerPosition.y + 2f);
        }
        else
        {
            spawnPosition = new Vector2(x[Random.Range(0,2)], playerPosition.y + 2f);
        }
       
        for(int i = 0; i < 3;i++) 
        {
            spawnPosition.x = x[Random.Range(0,2)];
            spawnPosition.y += i;
            if(spawnPosition.x == -2)  forkSpawned = Fork[0];
            else  forkSpawned = Fork[1];
            Instantiate(forkSpawned,spawnPosition, forkSpawned.transform.rotation);
        }    
        Vector2 triggerPosition = new Vector2(0,playerPosition.y + 4.5f);
        LastTrigger = Instantiate(trigger, triggerPosition, Quaternion.identity);
        
    }
}
