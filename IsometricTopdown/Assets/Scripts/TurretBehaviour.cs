using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject shoontingpoint;
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private LayerMask layer;

    private Vector3 direction;

    [SerializeField]
    private GameObject EnemyBullet;
    [SerializeField]
    private float fireRate;
    private float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControladorRotacion();
        direction = new Vector3(target.transform.position.x, shoontingpoint.transform.position.y, target.transform.position.z) - shoontingpoint.transform.position;
    }

    void ControladorRotacion()
    {
        RaycastHit hit;
        if (Physics.Raycast(shoontingpoint.transform.position, direction, out hit, layer)) {
            if (hit.transform.gameObject.tag == "Player")
            {
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
                Shoot();
            }
            else
            {
                //Debug.Log("NO HIT");
            }
        }
        Debug.DrawRay(shoontingpoint.transform.position, direction, Color.green);
    }

    private void Shoot()
    {
        if (cooldown + fireRate <= Time.time)
        {
            cooldown = Time.time;
            Instantiate(EnemyBullet, shoontingpoint.transform.position, this.transform.rotation);
        }
    }
}

    
