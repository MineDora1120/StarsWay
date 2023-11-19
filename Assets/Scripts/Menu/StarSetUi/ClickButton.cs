using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public string buttonType;
    public GameObject left, right;
    private SpriteRenderer leftSpr, rightSpr;

    // Update is called once per frame
    private void Start()
    {
        leftSpr = left.GetComponent<SpriteRenderer>();
        rightSpr = right.GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (MenuManager.starSet >= 5) rightSpr.enabled = false;
        else rightSpr.enabled = true;

        if (MenuManager.starSet <= 1) leftSpr.enabled = false;
        else leftSpr.enabled = true;
    }
    void OnMouseDown()
    {

        if (buttonType == "Left")
        {
            leftSpr.color = Color.green;
            if (MenuManager.starSet > 1) MenuManager.starSet--;
        }
        else if (buttonType == "Right")
        {
            rightSpr.color = Color.green;
            if (MenuManager.starSet < 5) MenuManager.starSet++;
        }
    }
    private void OnMouseUp()
    {
        if (buttonType == "Left") leftSpr.color = new Color(0, 255, 255, 255);
        if (buttonType == "Right") rightSpr.color = new Color(0, 255, 255, 255);
    }
}
