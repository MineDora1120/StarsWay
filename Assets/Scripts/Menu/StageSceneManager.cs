using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(Fade.FadeIn(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
