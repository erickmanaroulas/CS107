﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraEmTorno : MonoBehaviour
{
    public Transform alvo;
    public float velocidade;
    public Vector3 eixoDeRotacao =  new Vector3(0, 1, 0);


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(alvo.position, eixoDeRotacao, velocidade * Time.deltaTime);
    }
}
