using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Digit2Incrementer : MonoBehaviour
{
    static SpriteRenderer spriteRenderer;
    static string[] possible_digits = {"number0", "number1", "number2", "number3", "number4", "number5"
    , "number6", "number7", "number8", "number9"};
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void increment_digits()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>(possible_digits[PlayerMovement.score / 10]);
    }
}
