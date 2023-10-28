using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float letterDelay = 0.1f, AfterDelay = 2;
    TextTyping TextFunction;
    string[] texts = new string[] { "평화롭던 어느날...", "이상현은 도트르ㅜㄹ 존나잘짠다" };
    void Start()
    {
        TextFunction = FindObjectOfType<TextTyping>();
        StartCoroutine(TextFunction.Printf(AfterDelay, letterDelay, texts));
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
