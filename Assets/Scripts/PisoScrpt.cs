using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoScrpt : MonoBehaviour
{
    public int resistencia;
    public SphereScript esfera;

    //Cuando un objeto colisione con este
    //debe escribirse en la consola la plabra "Contacto"
    private void OnCollisionEnter(Collision collision)
    {
        esfera = collision.gameObject.GetComponent<SphereScript>();
        Debug.Log("Contacto con una esfera que pesa " + esfera.peso);
    }
}
