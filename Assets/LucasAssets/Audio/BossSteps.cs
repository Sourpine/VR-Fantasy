using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSteps : MonoBehaviour
{
    public float timer1;
    public float timer2;
    public float timer3;
    public AudioSource stomp1;
    public AudioSource stomp2;
    public AudioSource stomp3;
    public AudioClip s1;
    public AudioClip s2;
    public AudioClip s3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void bruh()
    {
        
            Debug.Log("step");
            StartCoroutine(Sound1());
      
    }
    IEnumerator Sound1()
    {
       // StartCoroutine(Sound2());
        yield return new WaitForSeconds(timer1);
        stomp1.PlayOneShot(s1);
    }
    IEnumerator Sound2()
    {
       // StartCoroutine(Sound3());
        yield return new WaitForSeconds(timer2);
        stomp2.PlayOneShot(s2);

    }
    IEnumerator Sound3()
    {
        yield return new WaitForSeconds(timer3);
        stomp3.PlayOneShot(s3);

    }
}
