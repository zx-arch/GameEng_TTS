using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // public Camera cam;
    public NavMeshAgent agent;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.position);

        // if(Input.GetMouseButtonDown(0)){
        //     Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit hit;

        //     if (Physics.Raycast (ray, out hit)){
        //         agent.SetDestination(hit.point);
        //     }
        // }

    }
}
