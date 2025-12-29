using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantita : MonoBehaviour
{
    public Animator plantAnimations;

    public GameObject Coliderwarning;

    private float warningtime = 5f;

    private float Endtime = 0f;

    public SpriteRenderer Plant;

    public Collider2D colisionActivate;

    public GameObject Bitecollision;

    private void Start()
    {
      
    }


    private void Update()
    {
        if (warningtime == Endtime)
        {

            Bitecollision.SetActive(true);
        }
        else
        {
            warningtime -= Time.deltaTime;

        }


    }


}
