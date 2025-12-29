using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public GameObject transition;
    private int Vidas;

    public void Start()
    {
        Vidas = PlayerPrefs.GetInt("vidas");
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        transition.SetActive(true);
        Vidas++;
        PlayerPrefs.SetInt("vidas", Vidas);
        Invoke("starnewlevel", 2);
    }
    void starnewlevel()
    {
        SceneManager.LoadScene("Mike1_2");
    }
}
