using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHandCombos : MonoBehaviour
{
    public bool handIn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hand is " + handIn);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ComboTrigger")
        {
            handIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ComboTrigger")
        {
            handIn = false;
        }
    }
}
