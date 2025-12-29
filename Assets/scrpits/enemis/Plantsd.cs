using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantsd : MonoBehaviour
{
    public Animator plantAnimations;
    public GameObject Coliderwarning; 
    public GameObject Bitecollision;  

    public float timeToAttack = 2.0f;
    private float timer;
    private bool playerInRange = false;

    private void Start()
    {
        timer = timeToAttack;
        Bitecollision.SetActive(false);
        Coliderwarning.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange)
        {
   
            timer -= Time.deltaTime;


            if (timer <= timeToAttack / 2)
            {
                Coliderwarning.SetActive(true);
            }

          
            if (timer <= 0)
            {
                Atacar();
            }
        }
    }

    void Atacar()
    {
        Bitecollision.SetActive(true);
        plantAnimations.SetTrigger("Bite"); 

      
        timer = timeToAttack;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            timer = timeToAttack; 
            Coliderwarning.SetActive(false);
            Bitecollision.SetActive(false);
        }
    }
}
