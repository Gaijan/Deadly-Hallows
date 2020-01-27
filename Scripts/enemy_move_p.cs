using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_p : MonoBehaviour
    
    {
        public float speed2;
        public bool MoveRight2;
        // Use this for initialization
        void Update()
        {
            if (MoveRight2)
            {
                transform.Translate(2 * Time.deltaTime * speed2, 0, 0);
                transform.localScale = new Vector2(1, 1);
            }
            else
            {
                transform.Translate(-2 * Time.deltaTime * speed2, 0, 0);
                transform.localScale = new Vector2(-1, 1);
            }


        }
        void OnTriggerEnter2D(Collider2D trig)
        {
            if (trig.gameObject.CompareTag("turn")) ;
            if (MoveRight2)
            {
                MoveRight2 = false;
            }
            else
            {
                MoveRight2 = true;
            }
        }
    }
