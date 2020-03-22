using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 12f;
    public float jumpSpeed = 15f;
    public bool groundCheck = true;
    public Rigidbody2D rb;

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * Time.deltaTime * moveSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck == true || Input.GetKeyDown(KeyCode.W) && groundCheck == true || Input.GetKeyDown(KeyCode.UpArrow) && groundCheck == true)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            groundCheck = true;
        }
        if (collision.collider.tag == "PlatformDisappear")
        {
            groundCheck = true;
            Destroy(collision.gameObject,2);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            groundCheck = false;
        }
        if (collision.collider.tag == "PlatformDisappear")
        {
            groundCheck = false;
        }
    }
}
