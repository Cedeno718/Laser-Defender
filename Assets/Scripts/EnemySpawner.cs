using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigSO currentWave; //reference to store enemy list

    
    void Start()
    {
        SpawnEnemies(); //calls this method
    }

    public WaveConfigSO GetCurrentWave() //returns a waveconfigso
    {
        return currentWave; //will return the current wave
    }
    void SpawnEnemies() //will go through the enemy list and spawn them into the world
    {
        for(int i = 0; i < currentWave.GetEnemyCount(); i++)
        {        
            Instantiate(currentWave.GetEnemyPrefab(i), 
                        currentWave.GetStartingWaypoint().position,
                    //To create methods that have a runtime.
                    //The GetStartinWaypoint will return to the transform, 
                    //and then positon goes to that position
                        Quaternion.identity, transform);
        }
   }
}
