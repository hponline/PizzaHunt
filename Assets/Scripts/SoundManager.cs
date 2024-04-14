using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip fireSound;
    [SerializeField] private AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Fire()
    {
        if (audioSource) 
        {
            audioSource.PlayOneShot(fireSound);
        }
    }

    public void Death() 
    {
        if (audioSource) 
        {
            audioSource.PlayOneShot(deathSound);
        }
    }
    
}
