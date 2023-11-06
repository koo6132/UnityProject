using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    void OnClick()
    {
        SceneManager.LoadScene("1");
    }
}
