using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoUltralisto : MonoBehaviour {
    public GameObject player;
    private NavMeshAgent nma;
	// Use this for initialization
	void Start () {
        nma = GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {
        nma.destination = player.transform.position;
    }
}
