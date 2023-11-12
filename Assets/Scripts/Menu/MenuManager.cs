using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int starNum = 1;
    public static int starSet = 1;
    public static int[] pendants = new int[3];
    public static int[,] clearData = new int[5, 3] { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }};
    void Start()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(Fade.FadeIn(0f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
