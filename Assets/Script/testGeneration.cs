using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGeneration : MonoBehaviour
{
    private GameObject platform;
    void awake()
    {
        platform = gameObject;  
    }

    
    void fixeUpdate()
    {
        platform.transform.position = new Vector3(25, 25, 0);
}
}

