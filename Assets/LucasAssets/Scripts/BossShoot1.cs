using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot1 : MonoBehaviour
{
    public GameObject player;
    public Vector3 distance;
    public float Range;
    public float reload;
    public float reloadTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reload += Time.deltaTime;
        distance = player.transform.position - transform.position;
        float distance2 = distance.magnitude;
        if (distance2 < Range && reload > reloadTime)
        {
            GetComponent<Animator>().SetTrigger("Fire");
            reload = 0;
        }
    }
}
