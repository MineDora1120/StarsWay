using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Button start;
    private bool startButtonStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fade.FadeIn(0f));
        start.onClick.AddListener(StartGame);
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

    void SceneFade()
    {
        startButtonStatus = false;
        SceneManager.LoadScene("Select");
    }
}
