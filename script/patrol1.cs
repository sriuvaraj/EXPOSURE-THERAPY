using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class patrol1 : MonoBehaviour
{
    // Start is called before the first frame update
    List<Transform>  points;
    private int destpoints = 0;
    NavMeshAgent agent;
    //public float speed = 0.5f;
    


    void Start()
    {
       
       agent = GetComponent<NavMeshAgent>();
        
       points = Location1.point;
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
      
    }

    
    void Patrol()
    {
        //Debug.Log(agent.remainingDistance);
        //Debug.Log(!agent.pathPending);
        //agent.speed = speed;
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            if (points.Count == 0)
            {
                return;
            }
            agent.destination = points[destpoints].position;
            destpoints = (destpoints + 1) % points.Count;
        }
    }
}
