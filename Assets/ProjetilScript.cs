using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //Essa classe possui um componente dependente, que é "Rigidbody"
public class ProjetilScript : MonoBehaviour
{    
    private float timeLimit = 3f;
    private float timer = 0;

    private Rigidbody m_Rigidbody;  //Referência interna ao componente "Rigidbody"

    private void Awake()
    {
        //Acessa o componente "Rigidbody" e o atribui ao valor da referência
        m_Rigidbody = GetComponent<Rigidbody>();//mas não se usa o rigidbody aqui?
    }    

    private void Update()
    {
        //Criar uma variável contadora
        timer += Time.deltaTime; //Atribuir o valor de "timer" com o tempo de atualização dos frames        
        //Comparar o valor do contador com o tempo limite
        //Se for igual ou maior...
        if(timer >= timeLimit)
        {
            //Resetar o contador
            timer = 0;
            //Destruir o Game Object
            Destroy(gameObject);
        }
       

    }
}
