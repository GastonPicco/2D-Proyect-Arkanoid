using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pelota : MonoBehaviour
{
    int disparo = 1;
    private float fuerza=0.8f;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0f, 4f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("space") && (disparo == 1) && (x < 0.9)))
        {
            disparo = 0;
            Debug.Log("Disparo");
            Debug.Log(fuerza);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerza , fuerza));
        }
        if ((Input.GetKeyDown("space") && (disparo == 1) && (x < 1.9)&&(x >= 0.9)))
        {
            disparo = 0;
            Debug.Log("Disparo");
            Debug.Log(fuerza);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-fuerza, fuerza));
        }
        if ((Input.GetKeyDown("space") && (disparo == 1) && (x < 2.9) && (x >= 1.9)))
        {
            disparo = 0;
            Debug.Log("Disparo");
            Debug.Log(fuerza);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-fuerza* 0.5125f , fuerza * 1.31f));
        }
        if ((Input.GetKeyDown("space") && (disparo == 1) && (x < 4) && (x >= 2.9)))
        {
            disparo = 0;
            Debug.Log("Disparo");
            Debug.Log(fuerza);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerza * 0.5125f, fuerza * 1.31f));
        }
        if (transform.position.y <= -13.6)
        {
            SceneManager.LoadScene("LOSE");
        }
    }
}
