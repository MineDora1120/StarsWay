using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public static bool isPlay = false;
    private AudioSource audioSource;
    // Start is called before the first frame update

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (isPlay)
        {
            audioSource.Stop();
        };
        isPlay = true;
        DontDestroyOnLoad(gameObject);
    }
}
