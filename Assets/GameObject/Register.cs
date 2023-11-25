using System;
using UnityEngine;
using System.IO;
using Unity.VisualScripting;

public class Register : MonoBehaviour
{
    public LayerMask[] targetLayer;
    string str = "";
    // Start is called before the first frame update
    void Start()
    {
        for (int num = 0;  num <= 15; num++)
        {
            str += "new List<List<float>> { " + Environment.NewLine;
            
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 10000f, targetLayer[num]);
            foreach (Collider2D collider in colliders)
            {
                str += "new List<float> { " + collider.transform.position.x + "f , " + collider.transform.position.y + "f , " + collider.transform.rotation.eulerAngles.z + "f }," + Environment.NewLine;
            }
            str += "},  " + Environment.NewLine;
        }
        string path = Path.Combine(Application.persistentDataPath, "map.txt");
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            writer.Write(str);
        }
        Debug.Log("Text file saved to: " + path);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
