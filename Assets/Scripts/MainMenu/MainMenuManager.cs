using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fade.FadeIn(0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
