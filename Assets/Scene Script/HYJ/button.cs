using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject A;
    public AudioSource b;
    public event Action onTriggerButton;
    public GameObject UiButton;

    private void Start()
    {
        UiButton.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            UiButton.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("¹®¿­¸²");
                A.SetActive(false);
                b.Play();
                onTriggerButton?.Invoke();
                UiButton.SetActive(false);

            }
        }
        
    }
 
    private void OnCollisionExit(Collision collision)
    {
        UiButton.SetActive(false);
    }




}
