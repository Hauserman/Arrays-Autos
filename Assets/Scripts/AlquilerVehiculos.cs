using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;
    float precioactual;
    float total;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            if (vehiculos[i].cantRuedas > 3)
            {
                vehiculos[i].CartelPromo.gameObject.SetActive(false);
            }
            
        }

        for (int i = 0; i < vehiculos.Length; i++)
        {
            precioactual = vehiculos[i].precioAlquiler;
            total += precioactual;
        }
        total = total / vehiculos.Length;
        Debug.Log("Promedio de precio de alquiler es: " + total);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
           ResetearVehiculos();
        }   
    }

    void ResetearVehiculos()
    {
        int randomnum = Random.Range(0, vehiculos.Length);
        
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].CartelPromo.gameObject.SetActive(false);
        }

        vehiculos[randomnum].CartelPromo.gameObject.SetActive(true);

    }
}
