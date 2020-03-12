using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrooperShoot : MonoBehaviour
{
    public bool shoot;
    public Transform barrelLocation;
    public GameObject bulletPrefab;
    public float shotPower;
   // public AudioSource bang;
    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;
        
    }
    public void TriggerShoot()
    {
        GetComponent<Animator>().SetBool("Bruh", true);

    }
    public void stopShoot()
    {
        GetComponent<Animator>().SetBool("Bruh", false);
    }

    // Update is called once per frame
    void Update()
    {
        /* if (shoot)
           {
               GetComponent<Animator>().SetBool("Bruh", true);
           }
           if (!shoot)
           {
               GetComponent<Animator>().SetBool("Bruh", false);
          }*/
    }


    void Fire()
    {



        Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
    }
}
