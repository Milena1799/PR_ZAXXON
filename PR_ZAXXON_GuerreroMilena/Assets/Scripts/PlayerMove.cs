
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 10f;
        rotationSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");
        float desplR = Input.GetAxis("Rotar");

        print(desplR);
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplV, Space.World);

        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);

        
    }
}
