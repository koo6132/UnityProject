using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Source : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource mse;
    public AudioSource cat;
    public void SetMusicVolume(float volume) 
    {
        mse.volume = volume;
    }
    public void SetMusicCatVolume(float volume)
    {
        cat.volume = volume;
    }

    public void OnSfx() 
    { 
        cat.Play();
    }
}
