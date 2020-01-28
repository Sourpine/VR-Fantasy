using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public bool shooting = false;
    public float timeBtwnShots = 2f;
    public float timer = 0f;
    public GameObject bulletPrefab;
    public GameObject barrelEnd;
    public float bulletSpeed;
    public float rayLength = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 destination;
        if (Physics.Raycast(barrelEnd.transform.position, barrelEnd.transform.forward, out hit, 50))
        {
            destination = hit.point;
        }
        else
        {
            destination = barrelEnd.transform.position + rayLength * barrelEnd.transform.forward;
        }
        Vector3 direction = destination - barrelEnd.transform.position;
        direction.Normalize();
        if (/*get the variable that calls the attack anim and if true */shooting == true)
        {
            shooting = true;
        }
        if (shooting == true)
        {
            timer += Time.deltaTime;
        }
        if(timer >= timeBtwnShots)
        {
            GameObject projectile = Instantiate(bulletPrefab, barrelEnd.transform.position, barrelEnd.transform.localRotation);
            projectile.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
            Destroy(projectile, 5);
        }
    }
}
