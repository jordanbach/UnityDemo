using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    public AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClip1()
    {
        mySource.clip = clip1;
        mySource.Play();
    }

    public void PlayClip2()
    {
        mySource.clip = clip2;
        mySource.Play();
    }

    public void PlayClip3()
    {
        mySource.clip = clip3;
        mySource.Play();
    }
}
