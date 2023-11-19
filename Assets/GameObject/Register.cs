using System;
using UnityEngine;
using System.IO;

public class Register : MonoBehaviour
{
    string fileName;
    public LayerMask[] targetLayer;
    string str;
    // Start is called before the first frame update
    void Start()
    {
        for (int num = 0;  num <= 15; num++)
        {
            string path = Path.Combine(Application.persistentDataPath, num.ToString() + ".txt");
            str = num.ToString() + Environment.NewLine;
            
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1000f, targetLayer[num]);
            foreach (Collider2D collider in colliders)
            {
                str += "new List<float> { " + collider.transform.position.x + "f , " + collider.transform.position.y + "f , " + collider.transform.rotation.eulerAngles.z + "f }," + Environment.NewLine;
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(str);
            }
            Debug.Log("Text file saved to: " + path);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
