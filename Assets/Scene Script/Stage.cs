using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    private int clearedStage;
    public Stage instance;
    public Image stageImage;
    public Text stageNameText;
    public Button startButton;
    [SerializeField]
    private string[] stageName = { "1", "2", "3", "4" };
    public int index = 0;

    private void Start()
    {
        stageNameText = transform.Find("Stage").GetComponent<Text>();
    }
    
    public void onClickNextStage()
    {
        index++;
        if (index >= 4)
        {
            index = 0;
        }
    }

    public void onClickBackStage()
    {
        index--;
        if (index < 0)
        {
            index = 0;
        }
    }
    private void Update()
    {
        stageNameText.text = stageName[index];
    }
    public void onClickStartButton()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
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

}
