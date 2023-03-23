using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabbloque1;
    public GameObject prefabbloque2;
    public GameObject prefabbloque3;
    public GameObject prefabbloque4;
    public GameObject prefabpelota;

    public GameObject posicion;
    int i;
    public float separacion; 
    void Start()
    {
        Instantiate(prefabbloque1, posicion.transform.position, Quaternion.identity);
        for(i=0;i<28; i=i + 4)
        {
            if (i <= 12) 
            {
                Instantiate(prefabbloque3, new Vector3(posicion.transform.position.x + i*2, posicion.transform.position.y + (2 * separacion), posicion.transform.position.z), Quaternion.identity);
            }
            if (i <= 6)
            {
                Instantiate(prefabbloque4, new Vector3((posicion.transform.position.x + i * 4)+4, posicion.transform.position.y + (-1 * separacion), posicion.transform.position.z), Quaternion.identity);
            }
            Instantiate(prefabbloque1, new Vector3(posicion.transform.position.x + i, posicion.transform.position.y, posicion.transform.position.z), Quaternion.identity);
            Instantiate(prefabbloque2, new Vector3(posicion.transform.position.x + i, posicion.transform.position.y+(1 * separacion), posicion.transform.position.z), Quaternion.identity);
            if (i==0 || i==8 || i== 12 || i==16 || i==24)
            {
                Instantiate(prefabbloque2, new Vector3(posicion.transform.position.x + i, posicion.transform.position.y - (1 * separacion), posicion.transform.position.z), Quaternion.identity);
            }
            Instantiate(prefabbloque1, new Vector3(posicion.transform.position.x + i, posicion.transform.position.y-(2 * separacion), posicion.transform.position.z), Quaternion.identity);
            Instantiate(prefabbloque2, new Vector3(posicion.transform.position.x + i, posicion.transform.position.y - (3 * separacion), posicion.transform.position.z), Quaternion.identity);
        }
        Instantiate(prefabpelota, new Vector3(posicion.transform.position.x + 12, posicion.transform.position.y -20, posicion.transform.position.z), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Instantiate(prefabbloque3, new Vector3(posicion.transform.position.x + i*2, posicion.transform.position.y + (2 * separacion), posicion.transform.position.z), Quaternion.identity);
}
