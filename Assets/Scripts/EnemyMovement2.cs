using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    bool enemy1_passed = false;
    private float enemy_speed = EnemyMovement.enemy_speed;
    Rigidbody2D rb;
    Vector3 enemy1pos;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(11.34f, -3.118f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        enemy1pos = EnemyMovement.pos;
        if (enemy1pos.x <= 3.6f)
            enemy1_passed = true;
        if (enemy1_passed)
        transform.Translate(enemy_speed, 0, 0);
    }
}
