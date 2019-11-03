using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Spaw;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawners", 0f,8.2f); 
    }

    // Update is called once per frame
    void Spawners()
    {
        Instantiate(Spaw,new Vector2(8.1f,(int)Random.Range(0f,3f)), Quaternion.identity);
    }
}
