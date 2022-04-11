//Un refugio de animales rescatados nos pide que le programemos una calculadora de alimento para saber qué costo tendrán que afrontar para darle de comer a sus animales.
//Los datos que tenemos son:
//Los gatos comen 300 g de alimento por día, y su código es G.
//Los perros comen 400 g de alimento por día, y su código es PP.
//Los perros grandes comen 700 g de alimento por día, y su código es PG.

//Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse.
//El programa debe cumplir los siguientes requerimientos:
//Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.
//Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que muestre el costo de la cantidad de alimento calculada.
//Debe mostrar mensajes de error(y no realizar el cálculo) si se ingresa un código no válido o si se ingresa una cantidad de días menor a 3.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio01 : MonoBehaviour
{
    public string animal;
    public int dias;

    void Start()
    {
        int totalG = (300*dias);
        int totalPP = (400*dias);
        int totalPG = (700*dias);

        if (dias < 3)
        {
            Debug.Log("error");
        }
        else if (animal == "G")
        {
            Debug.Log("Para este periodo se necesitan " + (totalG) + " gramos de alimento");
            Debug.Log("El costo por esta cantidad de alimento es " + (totalG * 80) / 100);
        }
        else if (animal == "PP")
        {
            Debug.Log("Para este periodo se necesitan " + (totalPP) + " gramos de alimento");
            Debug.Log("El costo por esta cantidad de alimento es " + (totalPP * 80) / 100);
        }
        else if (animal == "PG")
        {
            Debug.Log("Para este periodo se necesitan " + (totalPG) + " gramos de alimento");
            Debug.Log("El costo por esta cantidad de alimento es " + (totalPG * 80) / 100);
        }
        else
        {
            Debug.Log("error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
