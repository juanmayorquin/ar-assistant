using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Assistant : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;
    private int index = 0;

    [SerializeField] private AudioClip[] audios = new AudioClip[0];


    void Start()
    {
        if (audios.Length > 0)
        {
            audioSource.clip = audios[index];
            audioSource.Play();
        }
    }

    void Update()
    {
        animator.SetBool("hablando", audioSource.isPlaying);
    }

    public void LoadAudios(AudioClip[] audios)
    {
        index = 0;
        this.audios = audios;
        if (audios.Length > 0)
        {
            audioSource.clip = audios[index];
        }
        audioSource.Play();
    }

    public void IncreaseIndex()
    {
        if (index < audios.Length - 1)
        {
            index += 1;
            if (audios.Length > 0)
            {
                audioSource.clip = audios[index];
            }
            audioSource.Play();
        }
    }
}
