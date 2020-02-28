using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHP : MonoBehaviour
{
    public GameObject renderer2;
    public GameObject canvas;
    public GameObject part1;
    public GameObject part2;
    public float hp;
    public GameObject explosion;
    public AudioSource foo;
    public AudioClip boom;
    public bool gone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0 && !gone)
        {
            gone = true;
            foo.PlayOneShot(boom);
            Instantiate(explosion, transform.position, transform.rotation);
            renderer2.SetActive(false);
            canvas.SetActive(false);
            part1.SetActive(false);
            part2.SetActive(false);
        }
    }
}
