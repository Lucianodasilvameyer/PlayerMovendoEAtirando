using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody bala;          //Referência explícita ao prefab "Projetil"
    public Transform saida;         //Referência explícita ao componente Transform da "Saída"

    public float shotSpeed = 50f;

    private void Update()
    {
        //Verificar se a tecla espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Chamar a função "Shoot"
            Shoot();
        }
    }

    void Shoot()
    {

        //Cria uma variável do tipo Rigidbody
        Rigidbody instanciaProjetil;
        //Cria um GameObject na cena como(as) um Rigibdoy, e atribui a variável "instanciaProjetil"
        instanciaProjetil = Instantiate(bala, saida.position, saida.rotation) as Rigidbody;
        //Atribui a velocidade do Rigidbody, o vetor da posição "saída" apontando para frente
        //multiplicando pelo valor de "shotSpeed"
        instanciaProjetil.velocity = shotSpeed * saida.transform.forward; //aqui coloca direção e intensidade no velocity? é sempre assim?     
        
    }
}
