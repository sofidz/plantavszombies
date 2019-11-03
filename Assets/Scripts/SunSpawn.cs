using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject sun;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSun", 1f, Random.Range(2f, 4f));
    }
    public void SpawnSun(){
        Instantiate(sun,new Vector2((int)Random.Range(1f, 4f), 1f), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
