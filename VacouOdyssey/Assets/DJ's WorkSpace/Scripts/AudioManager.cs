using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    SoundList library;
    public AudioSource soundFXSource;
    public AudioSource musicSource;

    public void PlaySoundFX(AudioClip clip)
    {
        soundFXSource.clip = clip;
        soundFXSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }
    public void PlaySound2D(string soundName)
    {
        //sfx2DSource.pitch = Random.Range(lowPitch, 1);
        soundFXSource.PlayOneShot(library.GetClipFromName(soundName), 1);
    }
}