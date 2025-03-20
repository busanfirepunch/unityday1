using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NEWBOSS : MonoBehaviour
{

    public Transform player;
    private float detectionRange = 20f;

    private NavMeshAgent agent;

    

    // Start is called before the first frame update
    private void Start()
    {
             agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dostancePlayer =
            Vector3.Distance(player.position, player.position);
        if (dostancePlayer < detectionRange)
        {
            agent.SetDestination(player.position);
        }
    }
}
