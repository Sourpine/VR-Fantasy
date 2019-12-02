﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyEnemy : MonoBehaviour
{
    public List<GameObject> nearby;
    // Start is called before the first frame update
    void Start()
    {
        nearby = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(gameObject.name == "Red Enemy")
        {
            Debug.Log(gameObject.name + "'s list: " + nearby);
        }*/
        foreach(GameObject target in nearby)
        {
            Debug.Log(target.gameObject.name);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && !nearby.Contains(other.gameObject))
        {
            nearby.Add(other.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && !nearby.Contains(other.gameObject))
        {
            nearby.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && nearby.Contains(other.gameObject))
        {
            nearby.Remove(other.gameObject);
        }
    }
}
