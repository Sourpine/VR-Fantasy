using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrooperShoot : MonoBehaviour
{
    public bool shoot;
    public Transform BarrelLocation;
    public AudioSource bang;
    void Start()
    {
        if (BarrelLocation == null)
            BarrelLocation = transform;
        
    }
    public void TriggerShoot()
    {
        GetComponent<Animator>().SetBool("Fire", true);

    }
    public void stopShoot()
    {
        GetComponent<Animator>().SetBool("Fire", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
