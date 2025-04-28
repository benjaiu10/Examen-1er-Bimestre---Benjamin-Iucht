using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empresa : MonoBehaviour
{
    public int kgATransportar;
    public int distanciaEnKm;
    int minimaDistancia = 50;
    int precioUtilitarioPorHora = 3000;
    int precioPickupPorHora = 4500;
    int precioCamionPorHora = 7000;

    // Start is called before the first frame update
    void Start()
    {
        if (distanciaEnKm < 1 || kgATransportar < 100)
        {
            Debug.Log("Datos incorrectos");
        }
       else

        if (kgATransportar < 2000)
        {
            Debug.Log("Vehiculo Utilitario " + "el precio es de" + precioUtilitarioPorHora * distanciaEnKm / 25);
        }
        if (kgATransportar > 2000 && kgATransportar < 5000)
        {
            Debug.Log("Vehiculo Pickup " + "el precio es de" + precioPickupPorHora * distanciaEnKm / 25);
        }
        if (kgATransportar > 5000 && kgATransportar < 10000)
        {
            Debug.Log("Vehiculo Camion " + "el precio es de" + precioCamionPorHora * distanciaEnKm / 25);
        }
        if (distanciaEnKm > 50)
        {
            
        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
