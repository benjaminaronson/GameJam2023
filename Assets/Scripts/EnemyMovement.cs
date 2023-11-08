using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public static Vector3 pos;
    public static float enemy_speed = -0.1f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3 (11.34f, -3.118f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (enemy_speed, 0, 0);
        pos = transform.position;
        float x_pos = pos.x;
       
    }
}
