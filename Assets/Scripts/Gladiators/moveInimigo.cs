using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class moveInimigo : MonoBehaviour
{
    public float visao = 20.0f;
    public Transform alvo;
    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, alvo.position) <= visao)
        {
            agente.isStopped = false;
            agente.SetDestination(alvo.position);
        }
        else
        {
            agente.isStopped = true;
        }

    }
}
