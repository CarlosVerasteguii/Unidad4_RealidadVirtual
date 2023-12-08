using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlaConversacion : MonoBehaviour
{
    [SerializeField]
    SO_Conversaciones conversaciones;
    [SerializeField]
    int indiceDialogo;

    GameObject contenedorPersonaje;
    Image imgPersonaje;

    GameObject textoDialogo;
    TextMeshProUGUI textoPersonaje;

    void Start()
    {
        indiceDialogo = 0;

        contenedorPersonaje = GameObject.Find("ContenedorPersonaje");
        imgPersonaje = contenedorPersonaje.GetComponent<Image>();

        textoDialogo = GameObject.Find("Texto Dialogo");
        textoPersonaje = textoDialogo.GetComponent<TextMeshProUGUI>();

        imgPersonaje.sprite = conversaciones.dialogos[indiceDialogo].personaje.img;
        textoPersonaje.text = conversaciones.dialogos[indiceDialogo].dialogo;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) // adelante
        {
            if (indiceDialogo < conversaciones.dialogos.Count - 1)
            {
                indiceDialogo++;
                imgPersonaje.sprite = conversaciones.dialogos[indiceDialogo].personaje.img;
            }
        }
        if (Input.GetKeyDown(KeyCode.A)) // atras
        {
            if (indiceDialogo > 0)
            {
                indiceDialogo--;
                imgPersonaje.sprite = conversaciones.dialogos[indiceDialogo].personaje.img;
            }
        }
    }
}
