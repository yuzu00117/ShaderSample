﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.SetColor( "BaseColor", Color.black );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
