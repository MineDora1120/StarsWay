using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startSetImage : MonoBehaviour
{
    public Sprite[] setSprite;
    public GameObject setObject;
    private SpriteRenderer setRenderer;
    // Start is called before the first frame update
    void Start()
    {
        setRenderer = setObject.GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setRenderer.sprite = setSprite[MenuManager.starSet-1];
    }
}
