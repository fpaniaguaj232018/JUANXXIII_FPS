using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huesitos : MonoBehaviour {
    Animator animator;
    bool andando = false;
    public float speed = 20;
	void Start () {
        animator = GetComponentInChildren<Animator>();
        Invoke("Andar", 10);
	}

    void Update()
    {
        if (andando)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
	
    void Andar()
    {
        andando = true;
        animator.SetBool("andando", true);
    }
	
}
