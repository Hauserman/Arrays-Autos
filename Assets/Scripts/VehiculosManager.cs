using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculosManager : MonoBehaviour
{

    public Vehiculo vehiculoscript;

    // Start is called before the first frame update
    void Start()
    {
        int ruedas = vehiculoscript.cantRuedas;
        Debug.Log("Cant ruedas: " + ruedas);
        if (ruedas < 6)
        {
            vehiculoscript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
