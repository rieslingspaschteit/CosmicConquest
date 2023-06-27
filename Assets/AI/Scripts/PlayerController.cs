using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update() {
        agent.SetDestination(new Vector3(22, 1, -7));

        // Lets the player game object move to where a left-mouse click was triggered.
        //if (Input.GetMouseButtonDown(0)) {
        //    Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(movePosition, out var hitInfo)) {
        //        agent.SetDestination(hitInfo.point);
        //    }
        //}
    }
}
