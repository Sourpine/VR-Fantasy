using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
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
        if (other.name == "FirePrefab(L)" || other.name == "FirePrefab(R)")
        {
            Debug.Log("FFFFFFFFFIIIIIIIIIIIIIIRRRRRRRRRRRRREEEEEEEEEEE!!!!!!!!!!!!!!!");
        }
    }

    private void OnCollisionEnter(Collision ollision)
    {
        if (ollision.gameObject.name == "FirePrefab(L)" || ollision.gameObject.name == "FirePrefab(R)")
        {
            Debug.Log("FFFFFFFFFIIIIIIIIIIIIIIRRRRRRRRRRRRREEEEEEEEEEE!!!!!!!!!!!!!!!");
        }
    }
}
