using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1LightOn : MonoBehaviour
{

    public GameObject B;
    AudioSource audio;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        B.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            B.SetActive(true);
            audio.Play();
            hasPlayed = true;
        }

    }
}

