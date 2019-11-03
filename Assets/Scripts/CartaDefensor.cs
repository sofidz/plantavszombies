using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaDefensor : MonoBehaviour
{
    // Start is called before the first frame update
    public string def; 
    private GameController game;
    
    void Start()
    {
        
    }
    public string Def()
    {
        return def;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUpAsButton()
    {
        def = gameObject.tag;   
        game = GameObject.Find("controlador").GetComponent<GameController>();
        game.semilla = this.gameObject;  
    }

    public void Hello(){
        Debug.Log("hola");
    }
}
