using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    [SerializeField]public float cpuntos = 20;
    [SerializeField]public Puntaje puntaje;
    public int golpes_necesarios = 2;
    public int golpes_dados = 0;
    public bool rompible = true;
    public GameObject pre50;
    public GameObject pre20;
    public GameObject pre5;
    


    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.tag == "pelota" && rompible)
        {
            Golpes();
        }
    }
    void Golpes()
    {
        Debug.Log("Hit");
        golpes_dados = golpes_dados + 1;
        if(golpes_dados == golpes_necesarios)
        {
            puntaje.SumarPuntos(cpuntos);
            if (cpuntos == 20)
            {
                
                Instantiate(pre20,new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
            if (cpuntos == 50)
            {
               
                Instantiate(pre50, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
            if (cpuntos == 5)
            {
                Instantiate(pre5, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }


            gameObject.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
