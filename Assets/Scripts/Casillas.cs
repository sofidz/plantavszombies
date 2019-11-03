using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casillas : MonoBehaviour
{
    // Start is called before the first frame update
    public CartaDefensor cartaDefensor; //Hago refenencia al otro Script y creo esa variable

    //GameObject tagCarta;
    private GameController gamecontroller;
    public string tagCarta;
    public GameObject[] defok;

    
    void Awake() {
        gamecontroller = GameObject.Find("controlador").GetComponent<GameController>();
    }



    void Start()
    {
        
        
    }
    void SpawnPlanta(GameObject[] defok){
        for (int i = 0; i < 5; i++)
        {
            if(defok[i].gameObject.tag == tagCarta){ //LO COMPARO CON EL TAG DE LA CARTA O EL DE SETEAR PLANTA?
                Instantiate(defok[i],new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                gameObject.tag = "ocupado";
            }
        }
    }
    
    void OnMouseUpAsButton()
    {   
        if(gameObject.tag == "vacio" && gamecontroller.semilla != null)
        {
            Debug.Log("dwadaw");
            cartaDefensor = gamecontroller.semilla.GetComponent<CartaDefensor>();   //CARTA DEFENSOR AHORA TIENE LO QUE TIENE DEF OSEA EL TAG DE LA CARTA
            Debug.Log(gamecontroller.semilla);
            tagCarta = cartaDefensor.Def();   // "TAGCARTA" TIENE EL TAG DE LA CARTA PRESIONADA
            defok = gamecontroller.array;
            SpawnPlanta(defok); 
        }
    }
}
