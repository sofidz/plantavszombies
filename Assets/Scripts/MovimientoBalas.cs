using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBalas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 5.2f);

    }
    
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Enemigo"){
            Destroy(other.gameObject);

        }
    }
}
