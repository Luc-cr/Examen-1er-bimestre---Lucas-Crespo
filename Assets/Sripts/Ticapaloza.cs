using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticapaloza : MonoBehaviour
{
    // Personas campo -> 20,400
    //Personas Plateas -> 16,200

    public int encampo;
    public int enplateas;

    const int campo = 1200;
    const int platea = 2000;
    int total;
    void Start()
    {
        if (encampo < 0 || enplateas < 0 || encampo > 20400 || enplateas > 16200)
        {
            Debug.Log("Error!!");
        }
        else
        {   
            if((encampo+enplateas) == 36600)
            {
                Debug.Log("Sold out!!");
            }

            Debug.Log("Recaudacion del campo: " + campo * encampo);
            Debug.Log("Recaudacion de la platea: " + platea * enplateas);

            total = campo * encampo + platea * enplateas;

            Debug.Log("Recaudacion total: " + total);
            Debug.Log($"Quedo {20400 - encampo} espacios en el campo y {16200 - enplateas} espacios en la platea \n En total son {20400 - encampo + 16200 - enplateas} espacios");

            if (encampo + enplateas >= 18300)
            {
                Debug.Log("El festival fue un exito! :)");
            }
            else if (encampo + enplateas < 18300)
            {
                Debug.Log("Debemos mejorar la convocatoria :(");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
