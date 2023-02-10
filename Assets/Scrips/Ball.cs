using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 dir;
    float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * Time.deltaTime * speed);
    }

    void ResetBall()
    {
        //0 ball pos, random direction and normalize
        transform.position = Vector3.zero;
        dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1 / 2f, 1 / 2f));
        dir.Normalize();
    }

     void OnCollisionEnter2D(Collision2D coll)
    {
        //if ball hits wall = vertical
        //is paddle == horizontal
        //for solid non trigger coll
        if (coll.gameObject.tag.Equals("Wall"))
        {
            dir.y = -dir.y;
        }

        if (coll.gameObject.tag.Equals("Paddle"))
        {
            dir.x = -dir.x;
        }

      
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag.Equals("Bound"))
        {
            
            if (transform.position.x > 0)
            {
                ScoreManager.instance.AddScore(true, 1);
            } 
            else
            {
                ScoreManager.instance.AddScore(false, 1);
            }
            ResetBall();
        }
        if (trig.gameObject.tag.Equals("Paddle"))
        {
            dir.x = -dir.x;
        }

    }
}
