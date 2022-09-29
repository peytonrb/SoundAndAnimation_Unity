using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip1;
    public AudioClip musicClip2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            musicSource.clip = musicClip1;
            musicSource.Play();
        }       

        if (Input.GetKeyUp(KeyCode.W)) {
            musicSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            musicSource.clip = musicClip2;
            musicSource.Play();
        }       

        if (Input.GetKeyUp(KeyCode.R)) {
            musicSource.Stop();
        }
    }
}
