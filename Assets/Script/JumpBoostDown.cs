using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostDown : MonoBehaviour, IClickable
{
    public Jump jump;
    private void Start()
    {
        jump = FindObjectOfType<Jump>();
    }

    public void click()
    {

        jump.jumpForce -= 1.6f;
        Destroy(gameObject);
    }
}
