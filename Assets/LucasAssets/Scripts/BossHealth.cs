using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class BossHealth : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public float restoreRate;
    public GameObject drone;
    public GameObject renderer1;
    public Slider hpslider;
    public GameObject Explosion;
    public bool dead;
    public AudioSource srcs;
    public AudioClip boom;
    public bool isdrone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpslider.value = health;
        if(health <= 0 && !dead)
        {
            dead = true;
            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;

            renderer1.SetActive(false);
            srcs.Stop();
            srcs.PlayOneShot(boom);
            Instantiate(Explosion, transform.position, transform.rotation);
            StartCoroutine(death());
            
        }
        if(health < maxHealth && drone.GetComponent<BossHealth>().dead == false && isdrone == false)
        {
            health += restoreRate;
        }
    }
    IEnumerator death()
    {

        yield return new WaitForSeconds(2.5f);
        if (!isdrone)
        {
        Destroy(gameObject);
        }
    }
}
