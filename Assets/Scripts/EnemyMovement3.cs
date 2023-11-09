using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement3 : MonoBehaviour
{
    bool enemy2_passed = false;
    private float enemy_speed = EnemyMovement.enemy_speed;
    Rigidbody2D rb;
    Vector3 enemy2pos;
    // Start is called before the first frame update
    void Start()
    {
        enemy2pos = EnemyMovement2.e2pos;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(11.34f, -3.118f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        enemy2pos = EnemyMovement2.e2pos;
        if (enemy2pos.x <= 4.2f)
        {
            enemy2_passed = true;
        }
        if (enemy2_passed)
        {
            transform.Translate(Time.deltaTime * enemy_speed, 0, 0);
        }
            
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            transform.position = new Vector3(11.34f, -3.118f, 0f);
        }
    }
}
