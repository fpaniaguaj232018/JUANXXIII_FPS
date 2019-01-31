using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lemmon : MonoBehaviour {
    float correccion = 0.001f;
    float speed = 3;
    float angularSpeed = 10;
    float delta;
    float y = 0;

	void Update () {
        y += Time.deltaTime*speed;
        delta = Mathf.Cos(y)*correccion;
        transform.Translate(new Vector3(0, delta, 0));
        transform.Rotate(0, 1*Time.deltaTime*angularSpeed, 0);
	}
}
