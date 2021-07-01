using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    [SerializeField]
    private Transform personaje;
    [SerializeField]
    private Vector3 offsetTarget;
    [SerializeField]
    private float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoCam();
    }

    void MovimientoCam() {
        transform.position = Vector3.Lerp(transform.position, personaje.position + offsetTarget, velocidad * Time.deltaTime);
    }
}
