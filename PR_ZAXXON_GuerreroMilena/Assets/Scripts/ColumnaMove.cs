using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaMove : MonoBehaviour
{
    [SerializeField] GameObject objeto;
    private Variables variables_Objetos;
    int  speed;
   
    // Start is called before the first frame update
    void Start()
    {
        objeto = GameObject.Find("Variables");
        variables_Objetos = objeto.GetComponent<Variables>();
      
    }

    // Update is called once per frame
    void Update()
    {
        speed = variables_Objetos.velocidad;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

  
}


