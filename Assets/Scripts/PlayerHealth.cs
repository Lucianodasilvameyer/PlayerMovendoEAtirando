using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   
    
    //--
    //Declaração de variáveis
    
    private int health = 100; //Variável ou campo    //aqui se tivese usado serializefield em cima a variavel health apareceria no inspector com h maiusculo? 

    public int Health //Propriedade   //perguntar sobre a propriedade alterando o valor no inspector e o text?
    {
        get
        {
            return health;
        }
        set
        {
            health = value;

            MostraVida();
        }
    }

    void MostraVida()
    {
        Debug.Log("A vida é: " + health);
    }

    //--
    //Declaração de funções
}
