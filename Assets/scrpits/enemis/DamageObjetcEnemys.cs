using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageObjetcEnemys : MonoBehaviour
{

    DamegeObject DO;

    private int Vidas;

    // Start is called before the first frame update
    void Start()
    {
        Vidas = PlayerPrefs.GetInt("vidas");
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("player damage");
            Destroy(collision.gameObject);
            Vidas--;
            PlayerPrefs.SetInt("vidas", Vidas);
            if (Vidas > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (Vidas == 0)
        {
            DO = FindObjectOfType<DamegeObject>();
            DO.Perdiste();
        }

    }
}
