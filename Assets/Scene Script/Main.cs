using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main: MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnRetry()
    {
        switch (index)
        {
            case 0:
                SceneManager.LoadScene("1");
                break;
            case 1:
                SceneManager.LoadScene("2");
                break;
            case 2:
                SceneManager.LoadScene("3");
                break;
            case 3:
                SceneManager.LoadScene("4");
                break;
        }
    }
    public void OnMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnChapter()
    {
        SceneManager.LoadScene("Chapter");
    }
    public void OnOption()
    {
        SceneManager.LoadScene("Option");
    }
    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
