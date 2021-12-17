using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botte : MonoBehaviour
{
    public Jump jump;
    private void Awake()
    {
        jump = FindObjectOfType<Jump>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && (Input.GetKeyDown(KeyCode.E)))
        {
            jump.jumpForce += 5f;
            Destroy(gameObject);
        }
    }
}
