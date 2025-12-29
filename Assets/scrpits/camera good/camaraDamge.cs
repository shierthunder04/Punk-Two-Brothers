using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camaraDamge : MonoBehaviour
{
    public GameObject punk;
    public GameObject mike;

    public void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(punk);
        Destroy(mike);
    }
}
