using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoProjetilScript1 : MonoBehaviour
{
    private float timer=0;
    private float timerlimit=3f;
    private Rigidbody righ;
    // Start is called before the first frame update

    private void Awake()
    {
        righ = gameObject.GetComponent<Rigidbody>();          
    }


    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timerlimit)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
}
