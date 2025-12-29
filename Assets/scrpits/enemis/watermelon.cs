using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watermelon : MonoBehaviour
{
    public GameObject watrmelon;
    public GameObject here;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        watrmelon.SetActive(true);
        Destroy(gameObject);
    }

}
