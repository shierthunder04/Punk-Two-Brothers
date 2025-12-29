using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    
    public GameObject cinemattica;

    public void IntroTwo()
    {
        cinemattica.SetActive(true);
        Invoke("iniciar2", 2);
    }

    public void Introend()
    {
        cinemattica.SetActive(true);
        Invoke("fin", 2);
    }

    public void intro()
    {
        cinemattica.SetActive(true);
        Invoke("iniciar", 2);
    }

    public void Introend2()
    {
        cinemattica.SetActive(true);
        Invoke("fin2", 2);
    }

    void fin2()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void iniciar2()
    {
        SceneManager.LoadScene("intro2");
    }

    void menu()
    {
        SceneManager.LoadScene("mENU");
    }

    void fin()
    {
        SceneManager.LoadScene("Mike1_1");
    }

    void iniciar()
    {
        SceneManager.LoadScene("Intro");
    }

 public void levelselector()
    {
        SceneManager.LoadScene("Mode selector");
    }
    public void Raturn()
    {
        SceneManager.LoadScene("mENU");
    }

}
