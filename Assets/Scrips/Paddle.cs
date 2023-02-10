using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public int numInt = 8;
    public float numF = 8f;

    private float speed = 4f; //floats need a f at the end
    public KeyCode upKey;
    public KeyCode downKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }


        if (Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }


        /*
         * this is how to make a multi line code
         * If the paler presses up or down, paddel moves
         * GetAxsis is for a controller
         * GetKeyUp, down or whatever is a one frame deal
         * transform = objects
         * transform = entire transform class
         */




    }
}
