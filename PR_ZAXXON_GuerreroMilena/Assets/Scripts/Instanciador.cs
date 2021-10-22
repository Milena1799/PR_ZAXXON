using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] GameObject[] obstaculos;
    [SerializeField] Transform instantiatePosicion;
    // Start is called before the first frame update
    void Start()
    {

        intervalo = 0.5f;
      

     //corrutina obstaculos creadas
        StartCoroutine("CrearColumna");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CrearColumna()

    {
        while (true)
        {
            
            float randomX = Random.Range(-17f, 17f);
            //Genero un número aleatorio para elegir el obstaculo


            Vector3 newPos = new Vector3(randomX, instantiatePosicion.position.y, instantiatePosicion.position.z);

            int numAl = Random.Range(0, obstaculos.Length);
            Instantiate(obstaculos[numAl], newPos, Quaternion.identity);
            /*
            if (numAl == 0)
            {
                //instatantiate(columna, newPos, Quaterniom.identity)
            }
            else
            {
                //Igual que el if
            }
            */

            yield return new WaitForSeconds(intervalo);
            

        }

    }

}
