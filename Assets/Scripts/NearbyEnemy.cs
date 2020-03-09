using System.Collections;
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
        /*foreach(GameObject g in nearby)
        {
            Debug.Log(g.name);
        }*/
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "EnemyChild" && !nearby.Contains(other.gameObject))
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
