using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoListo : MonoBehaviour
{
    public float speed;
    public GameObject prefabExplosion;
    enum State { Walking, Following };
    private State state = State.Walking;
    public int vida = 100;
    private TextMesh textoVida;

    private Transform playerTransform;


    void Start()
    {
        textoVida = GetComponentInChildren<TextMesh>();
        InvokeRepeating("Rotar", 0, 3);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (state == State.Following)
        {
            transform.LookAt(playerTransform);
        }
        textoVida.text = vida.ToString();
    }
    void Rotar()
    {
        if (state != State.Following)
        {
            float delta = Random.Range(-180, 180);
            transform.Rotate(new Vector3(0, delta, 0));
        }
    }
    public void HacerDanyo(int danyo)
    {
        vida -= danyo;
        vida = Mathf.Max(vida, 0);
        if (vida == 0)
        {
            Instantiate(
                prefabExplosion, 
                transform.position, 
                transform.rotation);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            state = State.Following;
            playerTransform = collider.gameObject.transform;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            state = State.Walking;
        }
    }

}
