using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePosition : MonoBehaviour
{
    [SerializeField] private Camera Maincamera;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = Maincamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }
}
