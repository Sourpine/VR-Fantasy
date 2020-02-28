using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShield : MonoBehaviour
{
    public GameObject Drone;
    public GameObject Shield;
    public GameObject ShieldGen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShieldGen.GetComponent<ShieldHP>().hp <= 0)
        {
            Shield.SetActive(false);
        }
    }
}
