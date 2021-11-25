using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour, IClickable
{
    public Jump jump;
    public void click()
    {
        jump.jumpForce += 2;
        Destroy(gameObject);
    }
}
