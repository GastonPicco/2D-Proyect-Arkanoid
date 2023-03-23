using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float velocidad;
    float constant, sprint;
    public bool canmove;
    
    // Start is called before the first frame update
    void Start()
    {
        
        constant = velocidad;
        sprint = constant;
        canmove = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey("space"))&& (canmove == false))
        {
            canmove = true;
        }
        if ((Input.GetKey("left"))&&(transform.position.x >= -13.6)&&(canmove == true))
        {
            gameObject.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }
        if ((Input.GetKey("right"))&&(transform.position.x <= 13.6) && (canmove == true))
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            velocidad = constant + sprint;
        }
        else
        {
            velocidad = constant;
        }
    }
}
