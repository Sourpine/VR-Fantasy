using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearEnemyParent : MonoBehaviour
{
    public GameObject enemyParent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = enemyParent.transform.position;
    }
}
