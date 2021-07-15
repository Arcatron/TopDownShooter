using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    private Vector3 direccion;

    [SerializeField]
    private float velocidad;

    [SerializeField]
    private float distanciaMaxima;

    // Start is called before the first frame update
    void Start()
    {
        direccion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoBala();
    }
    void MovimientoBala()
    {
        if (Vector3.Distance(direccion, transform.position) > distanciaMaxima) {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Player")
        {
            Debug.Log("HIT");
        }
        Destroy(this.gameObject);
    }
}
