using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform direccion;
    [SerializeField]
    private GameObject bala;
    [SerializeField]
    private float fireRate;

    private float cooldown;

    public static ArmaBehaviour Instance;

    private void Awake()
    {
        Instance = GetComponent<ArmaBehaviour>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disparar() {
        if (cooldown + fireRate <= Time.time) {
            cooldown = Time.time;
            Instantiate(bala, direccion.position, direccion.rotation);
        }
    }
}
