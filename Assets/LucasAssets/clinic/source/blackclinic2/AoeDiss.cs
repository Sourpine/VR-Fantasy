using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoeDiss : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dissipate());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dissipate()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}
