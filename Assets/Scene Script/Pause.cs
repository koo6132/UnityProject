using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPause;
    public GameObject Canvas;
    public void Start()
    {
        Canvas.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
                Re();
            else
                stop();
        }
    }
    public void Re()
    {
        isPause = false;
        Time.timeScale = 1;
        Canvas.SetActive(false);
    }

    public void stop()
    {
        Time.timeScale = 0;
        Canvas.SetActive(true);
        isPause = true;

    }
}
