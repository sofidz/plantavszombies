using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DestroySun : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public TextMesh puntos;
    private static int dinero;
    void Start()
    {
        
        //puntos.text = "Dinero : 0 ";// + dinero.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        dinero+= 10;
        Destroy(gameObject);
        
        //puntos.text = "Dinero : 0 " + dinero.ToString();
        Debug.Log(dinero);
    }
}
