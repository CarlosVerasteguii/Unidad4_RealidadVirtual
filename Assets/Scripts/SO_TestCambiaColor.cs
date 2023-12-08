using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO_TestCambiaColor : MonoBehaviour
{
    [SerializeField]
    SO_CambiaColor scriptobj;

    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        r.material.color = scriptobj.color;

    }
}
