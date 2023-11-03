using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObj.transform.position.x >= -16.4f && playerObj.transform.position.x <= 16.4f) transform.position = new Vector3(playerObj.transform.position.x, transform.position.y, -10);
        if (playerObj.transform.position.y >= -5.72f) transform.position = new Vector3(transform.position.x, playerObj.transform.position.y, -10);
        else transform.position = new Vector3(transform.position.x, -5.72f, -10);
    }
}
