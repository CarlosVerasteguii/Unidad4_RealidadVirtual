using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conversacion ", menuName = "Conversaciones/Crear Conversacion ", order = 2)]

public class SO_Conversaciones : ScriptableObject

{
    [System.Serializable]
    public struct Dialogo
    {
        public SO_Personajes personaje;
        [TextArea(2, 5)]
        public string dialogo;
    }
    public List<Dialogo> dialogos;

}
