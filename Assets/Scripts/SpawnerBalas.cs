using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBalas : MonoBehaviour
{
public GameObject SpawEnemy;

    void Start()
    {
        InvokeRepeating("Spawners", 0f,2.2f); 
    }


    void Update()
    {
    
        
    }
    
    void Spawners()
    {
        Instantiate(SpawEnemy,transform.position, Quaternion.identity);
    }

}
