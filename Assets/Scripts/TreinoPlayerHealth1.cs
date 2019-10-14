using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoPlayerHealth1 : MonoBehaviour
{
    private int health=100;

    [SerializeField]
    private int healthMax;

    public int Health 
    {
        get
        {
            return health;
        }
        set
        {
            mostrarVida();

            health = value;

            if (health <= 0)
            {
                health = 0;
            }
            else if(health>=healthMax)
            {
                health = healthMax;
            }
            else
            {
                //(float)health / (float)healthMax; neste caso não averia uma terceira condição?
            }
                


        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void mostrarVida()
    {
        Debug.Log("A vida é: " + health);
    }
}
