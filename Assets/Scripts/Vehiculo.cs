using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    public int cantRuedas;
    public float precioAlquiler;
    public GameObject CartelPromo;
    public Vehiculo[] vehiculos;


    // Start is called before the first frame update
    void Start()
    {
        if (cantRuedas >= 4)
        {
            if (CartelPromo != null)
            {
                CartelPromo.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
