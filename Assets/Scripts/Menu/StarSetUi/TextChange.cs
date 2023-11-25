using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText, infoText;
    private string[] starName = new string[5] { "½ÖµÕÀÌÀÚ¸®", "¾çÀÚ¸®", "ÃµÄªÀÚ¸®", "ºÏµÎÄ¥¼º", "Ä«½Ã¿ÀÆä¾ÆÀÚ¸®" };
    private string[,] starNote = new string[,] { { "1-1", "1-2", "1-3" }, { "2-1", "2-2", "2-3" }, { "3-1", "3-2", "3-3" }, { "4-1", "4-2", "4-3" }, { "5-1", "5-2", "5-3" } };
    private char[] starOneName = new char[5] { '½Ö', '¾ç', 'Ãµ', 'ºÏ', 'Ä«' };
    private string[] pendantsInfo = new string[5] {"µÕ½Ç", "¼Ó·Â", "±¸ÀÏ", "½º¸ô", "È¥ÇÕ"};
    private int overNum = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectText.text = starOneName[MenuManager.starSet-1] + "-" + MenuManager.starNum.ToString();
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
        overNum = 0;
        for(int i = 0; i < 3; i++)
        {
            overNum += MenuManager.fragNum[MenuManager.starSet - 1, i];
        }
        if (overNum >= 3) infoText.text = pendantsInfo[MenuManager.starSet - 1] + " Ææ´øÆ® È¹µæ¿Ï·á!";
        else infoText.text = pendantsInfo[MenuManager.starSet - 1] + " Ææ´øÆ® È¹µæ±îÁö " + (3-overNum).ToString() + "Á¶°¢ ³²À½" ;
    }
}
