using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archivements_Menu : MonoBehaviour
{
    public GameObject MenuA;

    public GameObject MenuB;



    public void Archivement_Active()
    {
        MenuA.SetActive(false);
        MenuB.SetActive(true);
    }

    public void Archivements_desactive()
    {
        MenuB.SetActive(false);
        MenuA.SetActive(true);
    }

}
