using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shots : MonoBehaviour
{
    private float waitedTime;

    public float waittedTimeAttack = 3;

    public Animator animator;

    public GameObject bulletPrefab;

    public Transform Launcher;


    private void Start()
    {
        waitedTime = waittedTimeAttack;
    }

    private void Update()
    {
        if (waitedTime <= 0)
        {
            waitedTime = waittedTimeAttack;
            Invoke("LaunchBullet", 1);
        }
        else
        {
            waitedTime -= Time.deltaTime;
        }

    }
    public void LaunchBullet()
    {
        GameObject newBullet;
        animator.Play("shot");
        newBullet = Instantiate(bulletPrefab, Launcher.position, Launcher.rotation);
    }
}
