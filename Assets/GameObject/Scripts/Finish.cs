using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(Fade.FadeOut(0.5f));
            if (MenuManager.starNum >= 3) Invoke("GoMain", 2f);
            else Invoke("ReGame", 2f);
        }
    }
    void ReGame()
    {
        MenuManager.starNum++;
        SceneManager.LoadScene("Main");
    }
    void GoMain()
    {
        MenuManager.starNum = 0;
        MenuManager.starSet++;
        SceneManager.LoadScene("Select");
    }
}
