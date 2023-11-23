using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickInGameButton : MonoBehaviour
{
    public Button stopButton, reGameButton, MenuButton, retryButton;
    public GameObject Menu;
    public Text levelText;
    public Image stopButtonImage;
    public Sprite playImage, stopImage;
    private bool isStop = false, isReButton, isMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        isStop = false;
        isReButton = false;
        isMenuButton = false;
        stopButton.onClick.AddListener(ClickStopButton);
        reGameButton.onClick.AddListener(ClickReGameButton);
        MenuButton.onClick.AddListener(ClickMenuButton);
        retryButton.onClick.AddListener(ClickRetryButton);
        levelText.text = MenuManager.starSet.ToString() + "-" + MenuManager.starNum.ToString() + " 플레이중";
    }
    private void FixedUpdate()
    {
        if (isStop && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Space))) ClickStopButton(); 
        Menu.SetActive(isStop);
    }
    // Update is called once per frame
    public void ClickStopButton()
    {
        if (isStop)
        {
            isStop = false;
            stopButtonImage.sprite = stopImage;
        }
        else
        {
            isStop = true;
            stopButtonImage.sprite = playImage;
        }
    }
    public void ClickReGameButton()
    {
        if (!isReButton)
        {
            isReButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UiOne", 2f);
        }
    }
    public void ClickMenuButton()
    {
        if (!isMenuButton)
        {
            isMenuButton = true;
            StartCoroutine(Fade.FadeOut(0f));
            Invoke("UiTwo", 2f);
        }
    }
    public void ClickRetryButton()
    {
        isStop = false;
    }

    void UiOne()
    {
        SceneManager.LoadScene("Main");
        isReButton = false;
    }
    void UiTwo()
    {
        isMenuButton = false;
        SceneManager.LoadScene("Select");
    }
}
