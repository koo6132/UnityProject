using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
