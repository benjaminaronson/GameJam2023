using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    bool enemy1_passed = false;
    public static Vector3 e2pos;
    public static float enemy_speed = EnemyMovement.enemy_speed;
    Rigidbody2D rb;
    Vector3 enemy1pos;
  
    // Start is called before the first frame update
    void Start()
    {
        e2pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(11.34f, -3.118f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        enemy1pos = EnemyMovement.e1pos;
        e2pos = transform.position;
        if (enemy1pos.x <= 4.2f)
        {
            enemy1_passed = true;
            
        }
        
            
        if (enemy1_passed)
            transform.Translate(Time.deltaTime * enemy_speed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            transform.position = new Vector3(11.34f, -3.118f, 0f);
            enemy1_passed = false;
           
        }
    }
}
