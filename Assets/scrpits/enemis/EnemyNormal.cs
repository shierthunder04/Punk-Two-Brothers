using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNormal : MonoBehaviour
{
    public Animator aniamtor;

    public SpriteRenderer spriteRenderer;

    public float speed = 0.5f;

    private float waittime;

    public Transform[] moveSpots;

    public float startWaittime;

    private int i = 0;

    private Vector2 actualpos;


    // Start is called before the first frame update
    void Start()
    {
        waittime = startWaittime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(checkEnemymoving());

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waittime <= 0)
            {
                if (moveSpots[i] != moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waittime = startWaittime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }

    IEnumerator checkEnemymoving()
    {
        actualpos = transform.position;

        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualpos.x)
        {
            spriteRenderer.flipX = true;
            aniamtor.SetBool("idle", false);
        }
        else if (transform.position.x < actualpos.x)
        {
            spriteRenderer.flipX = false;
            aniamtor.SetBool("idle", false);
        }
        else if (transform.position.x == actualpos.x)
        {
            aniamtor.SetBool("idle", true);
        }
    }
}
