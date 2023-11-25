using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText, infoText;
    private string[] starName = new string[5] { "�ֵ����ڸ�", "���ڸ�", "õĪ�ڸ�", "�ϵ�ĥ��", "ī�ÿ�����ڸ�" };
    private string[,] starNote = new string[,] { { "1-1", "1-2", "1-3" }, { "2-1", "2-2", "2-3" }, { "3-1", "3-2", "3-3" }, { "4-1", "4-2", "4-3" }, { "5-1", "5-2", "5-3" } };
    private char[] starOneName = new char[5] { '��', '��', 'õ', '��', 'ī' };
    private string[] pendantsInfo = new string[5] {"�ս�", "�ӷ�", "����", "����", "ȥ��"};
    private int overNum = 0, pendantNum;
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
        if (SlotManager.clickPendantSlot)
        {
            if(MenuManager.pendants == 0) infoText.text = "���Ʈ ���� ���";
            else infoText.text = pendantsInfo[MenuManager.pendants-1] + " ���Ʈ �����.";
        } else
        {
            if (overNum >= 3) infoText.text = pendantsInfo[MenuManager.starSet - 1] + " ���Ʈ ȹ��Ϸ�!";
            else infoText.text = pendantsInfo[MenuManager.starSet - 1] + " ���Ʈ ȹ����� " + (3 - overNum).ToString() + "���� ����";
        }
    }
}
