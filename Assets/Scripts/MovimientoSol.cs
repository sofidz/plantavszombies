﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 2.2f);
    }
}
