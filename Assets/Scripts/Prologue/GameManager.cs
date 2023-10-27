using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float delayTime = 5f;
    void Start()
    {
        Application.targetFrameRate = 60;

        StartCoroutine(Fade.FadeIn(delayTime));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
