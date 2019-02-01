using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemigoListo"))
        {
            collision.gameObject.GetComponent<EnemigoListo>().HacerDanyo(1);
        }
    }
}
