using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;

    public float lifetime;

    public bool left;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }


    private void Update()
    {
        if (left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }


    }
}
