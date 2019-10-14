using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoPlayerMovement1 : MonoBehaviour
{
    public float velocidade = 3.5f;
    private Rigidbody righ;
    private Renderer m_renderer;
    private PlayerHealth playerHealth;

    // Start is called before the first frame update
    private void Awake()
    {

        righ = gameObject.GetComponent<Rigidbody>();
        m_renderer = gameObject.GetComponent<Renderer>();
        playerHealth = gameObject.GetComponent<PlayerHealth>();

    }
    private void Start()
    {
        playerHealth.Health = 50;
        m_renderer.material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void rotation()
    {
        if(Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.y = -0.5f;
            transform.Rotate(rotation*velocidade*2);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.y = 0.5f;
            transform.Rotate(rotation * velocidade * 2);
        }
    }
    void movimento()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.1f * velocidade);  //aqui no z posso colocar qualquer numero  possitivo para o player ir para frente?
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0,- 0.1f *velocidade);
        }

    }
}
