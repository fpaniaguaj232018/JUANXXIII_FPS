using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

    public GameObject prefabProyectil;
    public Transform puntoGeneracion;
    public float fuerzaDisparo = 0.1f;

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject proyectil =
                Instantiate(
                    prefabProyectil,
                    puntoGeneracion.position,
                    Quaternion.identity);
            proyectil.GetComponent<Rigidbody>().AddForce(
                transform.forward * fuerzaDisparo,
                ForceMode.Impulse);
            Destroy(proyectil, 3);
        }
	}
}
