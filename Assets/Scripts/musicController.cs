using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip musicClip;
    public float loopTime;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        musicClip = Resources.Load<AudioClip>("Musica/investigations");
        audioSource.clip = musicClip;
        audioSource.Play();
    }

    void Update()
    {
         if (audioSource.time >= loopTime * 60f)
        {
            audioSource.time = 31f;
        }
    }
}
