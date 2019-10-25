using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent agent;
    GameObject player;

    private void Awake () {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    private void Update () {
        MovementController();
    }

    private void MovementController () {
        agent.SetDestination(player.transform.position);
    }
}
