using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DamegeObject : MonoBehaviour
{
    public GameObject transition;

    public int vidas = 3;

    playermove PM;

    public GameObject camera;

    public TextMeshProUGUI texto;

    public void Start()
    {
        vidas = 3;
        texto.text = PlayerPrefs.GetInt("vidas").ToString();
       vidas = PlayerPrefs.GetInt("vidas");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("player damage");
            Destroy(collision.gameObject);
            vidas--;
            PlayerPrefs.SetInt("vidas", vidas);
            if (vidas > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
          
        }
   
        if(vidas == 0 )
        {
            vidas = 3;
            PlayerPrefs.SetInt("vidas", vidas);
            Invoke("Gameover", 2);
            transition.SetActive(true);
           
        }


    }
    void Gameover()
    {
        SceneManager.LoadScene("gameover");
    }

    public void Perdiste()
    {
        vidas = 3;
        PlayerPrefs.SetInt("vidas", vidas);
        Invoke("Gameover", 2);
        transition.SetActive(true);
    }
}
