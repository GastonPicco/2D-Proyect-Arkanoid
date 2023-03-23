using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuSimple");
    }
    public void WINS()
    {
        SceneManager.LoadScene("WIN");
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("!Quit");
    }
}
