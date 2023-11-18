using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText;
    private string[] starName = new string[5] { "�ֵ����ڸ�", "���ڸ�", "õĪ�ڸ�", "�ϵ�ĥ��", "ī�ÿ����" };
    private string[,] starNote = new string[,] { { "�������� ���� �༺�̱�. � ����ϱ�?", "�и� �� ���� ����ü�� �������ٵ�..", "����ü�� ���� �������� �������߰ڱ�."} };
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
        selectText.text = MenuManager.starSet.ToString() + "-" + MenuManager.starNum.ToString();
    }
}
