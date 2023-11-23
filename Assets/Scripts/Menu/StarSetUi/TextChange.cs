using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text firstText, selectTextNotice, selectText;
    private string[] starName = new string[5] { "�ֵ����ڸ�", "���ڸ�", "õĪ�ڸ�", "�ϵ�ĥ��", "ī�ÿ����" };
    private string[,] starNote = new string[,] { { "�������� ���� �༺�ΰ�!? ��Ű��Ű��!!", "����ü�� �����Ұǵ�.. ���������?", "��� ����ü��!!"}, { "ó������ �༺�̳�, ���� ������ ���̴°�?", "�����ִ� ����ü���� ������ �԰� ���?", "���ڸ� �̻��� ������� ���ĵȰ� ����."}, { "���� �����غ��̸鼭�� ����� �༺���� ���̳�.." , "��¦������, �ź�ο��� ������!" ,"���� �༺�� ������ ���ɱ�? �ı��� �Ǿ��ֳ�." }, { "������ �ߴ��� �༺�ΰ�? ����� ������ ��°�?", "�ܼ��Ѱ� �����鼭�� ������ �̴���..!", "���� �������� �༺�̳�! �̷����� ó���þ�!"} };
    private char[] starOneName = new char[5] { '��', '��', 'õ', '��', 'ī' };
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        firstText.text = starName[MenuManager.starSet - 1];
        selectText.text = starOneName[MenuManager.starSet-1] + "-" + MenuManager.starNum.ToString();
        selectTextNotice.text = starNote[MenuManager.starSet - 1, MenuManager.starNum - 1];
    }
}
