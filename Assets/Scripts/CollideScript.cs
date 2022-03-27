﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
public class CollideScript : MonoBehaviour
{   

    public bool canTeleport = true;
    public GameObject spawn;

    public int Id;

    void Awake() {
        Id = new System.Random().Next(1, 99999);
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