using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText;
    private string[] starName = new string[5] { "½ÖµÕÀÌÀÚ¸®", "¾çÀÚ¸®", "ÃµÄªÀÚ¸®", "ºÏµÎÄ¥¼º", "Ä«½Ã¿ÀÆä¾ÆÀÚ¸®" };
    private string[,] starNote = new string[,] { { "1-1","1-2","1-3" }, { "2-1", "2-2", "2-3" }, { "3-1", "3-2", "3-3" }, { "4-1","4-2","4-3" }, { "5-1", "5-2", "5-3" } };
    private char[] starOneName = new char[5] { '½Ö', '¾ç', 'Ãµ', 'ºÏ', 'Ä«' };
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectText.text = starOneName[MenuManager.starSet-1] + "-" + MenuManager.starNum.ToString();
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
    }
}
