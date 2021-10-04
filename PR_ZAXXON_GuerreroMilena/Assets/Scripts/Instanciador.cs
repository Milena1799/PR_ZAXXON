using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePosicion;
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;
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
            print("Hola");
            float randomX = Random.Range(-18f, 18f);
            Vector3 newPos = new Vector3(randomX, instantiatePosicion.position.y, instantiatePosicion.position.z);
            Instantiate(columna, newPos, Quaternion.identity);
            
            yield return new WaitForSeconds(intervalo);

        }
        
    }

}
