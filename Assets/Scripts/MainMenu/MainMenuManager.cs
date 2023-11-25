using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button start, info;
    [SerializeField] GameObject infoObj;
    private bool startButtonStatus = false, infoButtonStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        startButtonStatus = false;
        infoButtonStatus = false;
        StartCoroutine(Fade.FadeIn(0f));
        start.onClick.AddListener(StartGame);
        info.onClick.AddListener(InfoButton);
    }

    private void FixedUpdate()
    {
        infoObj.SetActive(infoButtonStatus);
        if (infoButtonStatus && Input.anyKey) infoButtonStatus = false; 
    }

    public void StartGame()
    {
        if(startButtonStatus == false)
        {
            startButtonStatus = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("SceneFade", 3f);
        }
    }
    public void InfoButton()
    {
        infoButtonStatus = true;
    }

    void SceneFade()
    {
        startButtonStatus = false;
        SceneManager.LoadScene("Select");
    }
}
