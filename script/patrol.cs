using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class patrol : MonoBehaviour
{
    // Start is called before the first frame update
    List<Transform>  points;
    private int destpoints;
    NavMeshAgent agent;
    //public Transform[] patrolPoints;
   // public float moveSpeed;
  //  private int currentPoint;

    void Start()
    {
       //transform.position = patrolPoints[0].position;
        //currentPoint = 0;
        agent = GetComponent<NavMeshAgent>();
       points = Location.point;
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
      /*  if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
        }
        if (currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed * Time.deltaTime);
    */
    }

    
    void Patrol()
    {
        if (true)
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
