using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump_velocity = 17;
    bool grounded = true;
    readonly float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float x_movement = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(x_movement, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
        bool is_jumping = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W);
        if (is_jumping && grounded) Jump();
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump_velocity);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
            
        }
    }
}
