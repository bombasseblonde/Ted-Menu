using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public AudioClip SinglePlayerMusic;


    private AudioSource source;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            source.clip = SinglePlayerMusic;
            source.Play();
        }

    }
}
