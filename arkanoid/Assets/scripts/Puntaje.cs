using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour
{
    public float puntos;
    public TextMeshProUGUI textMesh;
   
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //puntos += Time.deltaTime;
        if (puntos == 595)
        {
            SceneManager.LoadScene("WIN");
        }
        textMesh.text = puntos.ToString("0");

    }
    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
