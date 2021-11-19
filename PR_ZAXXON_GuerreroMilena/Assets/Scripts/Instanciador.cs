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
            int numAl = Random.Range(0, obstaculos.Length);
            float randomY;
            float randomX;

            //Genero un número aleatorio para elegir el obstaculo

            if (obstaculos[numAl].tag == "Cristal")
            {
                 randomX = Random.Range(-17f, 17f);
                 randomY = 20f;
            }
            else if (obstaculos[numAl].tag == "Cristal1")
            {
                randomX = Random.Range(-17f, 17f);
                randomY = 3f;
            }
            else
            {
                randomX = Random.Range(-17f, 17f);
                randomY = 0;
            }

            Vector3 newPos = new Vector3(randomX, randomY, instantiatePosicion.position.z);

           
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
