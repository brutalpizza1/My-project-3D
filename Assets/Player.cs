using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rbd;
    public float velocidade = 10;
    private Quaternion rotationInicial;
    public float velocidadeRotationY = 200;
    private float contRotationY = 0;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        rotationInicial = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        float lado = Input.GetAxis("Horizontal");
        float frente = Input.GetAxis("Vertical");

        rbd.velocity = transform.TransformDirection(new Vector3(lado * velocidade, rbd.velocity.y, frente * velocidade));

        // contRotationY = contRotationY + Input.GetAxis("Mouse X");
        // contRotationY = contRotationY * Time.deltaTime * velocidadeRotationY;

        contRotationY += Input.GetAxis("Mouse X") * Time.deltaTime * velocidadeRotationY;
        Quaternion novaRotacao = Quaternion.AngleAxis(contRotationY, Vector3.up);

        transform.localRotation = rotationInicial * novaRotacao;
    }
}
