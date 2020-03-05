using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BossShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject flash;
    public Transform barrelLocation;
    public float shotPower = 100f;
    public float range;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Fire()
    {
        Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
        Instantiate(flash, barrelLocation.position, barrelLocation.rotation);
    }
    public void disableAI()
    {
        gameObject.GetComponent<NavMeshAgent>().enabled = false;
    }
    public void enableAI()
    {
        gameObject.GetComponent<NavMeshAgent>().enabled = true;
    }
}
