using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource Bruh;
    public AudioClip Footstep;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sound()
    {
        Bruh.PlayOneShot(Footstep);
    }
}
