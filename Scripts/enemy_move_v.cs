using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_v : MonoBehaviour {
    public float speed;
    public bool MoveDown;
    // Use this for initialization
    void Update()
    {
        if (MoveDown)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);

        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }


    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn")) 
        if (MoveDown)
        {
            MoveDown = false;
        }
        else
        {
            MoveDown = true;
        }
    }
}
