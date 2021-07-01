using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControladorMovimiento();
        ControladorRotacion();
        ControladorDisparo();
    }

    void ControladorMovimiento() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal,0 , vertical);
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }

    void ControladorRotacion() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }

    void ControladorDisparo() {
        if (Input.GetButton("Fire1")) {
            ArmaBehaviour.Instance.Disparar();
        }
    }
}
