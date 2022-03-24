﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour
{   

    public bool canTeleport = true;
    public GameObject spawn;

    private void Awake()
    {
    //    body = GetComponent<Rigidbody>();
    }


    void Update(){

        if (Input.GetKeyDown("l"))
        {
            this.gameObject.transform.position = spawn.transform.position; 
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "OffMap")
        {
            this.gameObject.transform.position = spawn.transform.position;
        }

    }
    void OnTriggerStay(Collider other)
    {


    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag =="Object"){
            print("EXIT");
        }
    }

    
}
