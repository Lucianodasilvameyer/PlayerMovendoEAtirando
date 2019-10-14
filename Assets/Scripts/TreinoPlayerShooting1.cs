using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoPlayerShooting1 : MonoBehaviour
{
    public Rigidbody Bala;
    public Transform saida;

    public float shotSpeed=50f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            shoot();
        }
    }
    void shoot()
    {
        Rigidbody dispararBala = Instantiate(Bala, saida.position, saida.rotation) as Rigidbody;
        dispararBala.velocity = shotSpeed * saida.transform.forward;
    }

}
