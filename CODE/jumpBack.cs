﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position += new Vector3(0, 200, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += new Vector3(0, 200, 0);
    }
}
