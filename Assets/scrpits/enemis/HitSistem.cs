using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSistem : MonoBehaviour
{
    public Collider2D collider2D;

    public Animator aniamtor;

    public SpriteRenderer spriteRenderer;

    public GameObject destroyParticle;

    public float jumpforce = 2.5f;

    public int lifes = 2;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpforce);
            LosseLifeandhit();
            Checklife();
        }
    }
    public void LosseLifeandhit()
    {
        lifes--;
        aniamtor.Play("hit");
    }

    public void Checklife()
    {
        if (lifes == 0)
        {
            destroyParticle.SetActive(true);
            spriteRenderer.enabled = false;
            Invoke("enemyDie", 0.2f);
        }
    }
    public void enemyDie()
    {
        Destroy(gameObject);
    }


}
