using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public static Vector3 e1pos;
    public static float enemy_speed = -7f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.3f;
        e1pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3 (11.34f, -3.118f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Time.deltaTime * enemy_speed, 0, 0);
        e1pos = transform.position;
        float x_pos = e1pos.x;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            transform.position = new Vector3(11.34f, -3.118f, 0f);
        }
    }
}
