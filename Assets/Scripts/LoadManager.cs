using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loding());
    }

    IEnumerator Loding()
    {
        // Slider ��� �̸��� ���� �ڽ� ��ü�� ã�� �� �ڽ� ��ü�� ���� �Ǹ��� �Ӽ��� ��ü�� ��ȯ
        Slider slider = transform.GetChild(0).GetChild(0).GetComponent<Slider>();

        AsyncOperation oper = SceneManager.LoadSceneAsync("Main");

        // �Ǹ��� �� ����
        while (!(oper.progress >= 0.99f))
        {
            slider.value += oper.progress;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
