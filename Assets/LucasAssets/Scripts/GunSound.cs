using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{
    public AudioSource gunsource;
    public AudioClip chargesound;
    public AudioClip firesound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void charge()
    {
        gunsource.PlayOneShot(chargesound);
    }
    public void fireshot()
    {
        gunsource.PlayOneShot(firesound);
    }
}
