
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMov1 : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField]
    Transform jugador;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = jugador.position;


    }
}
