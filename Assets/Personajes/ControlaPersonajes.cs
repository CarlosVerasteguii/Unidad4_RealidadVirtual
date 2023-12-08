using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlaPersonajes : MonoBehaviour
{
    [SerializeField]
    List<SO_Personajes> personajes;
    [SerializeField]
    int indicePersonaje;

    GameObject contenedorPersonaje;
    Image imgPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        indicePersonaje = 0;

        contenedorPersonaje = GameObject.Find("ContenedorPersonaje");
        imgPersonaje = contenedorPersonaje.GetComponent<Image>();

        imgPersonaje.sprite = personajes[indicePersonaje].img;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//adelante
        {
            if (indicePersonaje < personajes.Count - 1)
            {
                indicePersonaje++;
                imgPersonaje.sprite = personajes[indicePersonaje].img;
            }

        }
        if (Input.GetKeyDown(KeyCode.D))//atras
        {
            if (indicePersonaje > 0)
            {
                indicePersonaje--;
                imgPersonaje.sprite = personajes[indicePersonaje].img;
            }
        }

    }
}
