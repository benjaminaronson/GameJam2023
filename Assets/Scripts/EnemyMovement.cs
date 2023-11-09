using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyMovement : MonoBehaviour
{
    float time_to_wait;
    public static Vector3 e1pos;
    public static float enemy_speed = -7f;
    Rigidbody2D rb;
    Vector3 e3pos;
    bool e3passed = true;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.3f;
        e1pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3 (11.34f, -3.118f, 0f);
        e3pos = EnemyMovement3.enemy3pos;

    }

    // Update is called once per frame
    void Update()
    {
        if (e3pos.x <= 4.2f)
        {
            e3passed = true;
            
            

        }
        if (e3passed)
        {
            
            time_to_wait = Random.Range(0, 0.5f);
            StartCoroutine(WaitForSeconds());
            transform.Translate(Time.deltaTime * enemy_speed, 0, 0);
        }
            
        e1pos = transform.position;
        float x_pos = e1pos.x;
        e3pos = EnemyMovement3.enemy3pos;
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(time_to_wait);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            transform.position = new Vector3(11.34f, -3.118f, 0f);
            e3passed = false;
   
        }
        
    }
    
}
