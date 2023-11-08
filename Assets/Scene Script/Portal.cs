using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int saveStage;
    public static  Portal instance;
    public int playerstage;
    public int stage;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(stage);
            PlayerPrefs.SetInt("PlayerStage", playerstage);
            Debug.Log("³ª°¬½À´Ï´Ù");
            
        }
        
    }
}

