using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    private Quaternion rotationInicial;
    public float velocidadeRotationX = 200;
    private float contRotationX = 0;
    // Start is called before the first frame update
    void Start()
    {
        rotationInicial = transform.localRotation;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        contRotationX += Input.GetAxis("Mouse Y") * Time.deltaTime * velocidadeRotationX;

        contRotationX = Mathf.Clamp(contRotationX, -60, 60);

        Quaternion novaRotacaoX = Quaternion.AngleAxis(contRotationX, Vector3.left);

        transform.localRotation = rotationInicial * novaRotacaoX;
    }
}
