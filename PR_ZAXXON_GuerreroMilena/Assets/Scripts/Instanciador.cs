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

        intervalo = 0.1f;
      

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
                 randomX = Random.Range(-24f, 24f);
                 randomY = 16f;
            }
            else if (obstaculos[numAl].tag == "Cristal1")
            {
                randomX = Random.Range(-24f, 24f);
                randomY = 4f;
            }
            else if (obstaculos[numAl].tag == "Vidas")
            {
                randomX = Random.Range(-24f, 24f);
                randomY = Random.Range(-4f, 16f);
            }
            else
            {
                randomX = Random.Range(-24f, 24f);
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
