using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoP : MonoBehaviour
{
    public int dañoP = 100;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<LogicaVida>().RestarVida(dañoP);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<LogicaVida>().RestarVida(dañoP);
        }
    }
}
