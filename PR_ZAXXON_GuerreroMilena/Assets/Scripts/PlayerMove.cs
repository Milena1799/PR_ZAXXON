
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float desplSpeed;
    [SerializeField] float rotationSpeed;

    [SerializeField] GameObject objeto;
    private Variables variables_Objetos;

    float limiteH = 24f;
    float limiteVDown = 3f;
    float limiteVUp = 20f;

    public int vidaPlayer;
    
    public Slider vidaVisual;

    [SerializeField] ParticleSystem Explosion;
   // int vidas;

   
    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 10f;
        rotationSpeed = 100f;
        objeto = GameObject.Find("Variables");
        variables_Objetos = objeto.GetComponent<Variables>();
        

       // vidas = Variables.vidas;
    }

    // Update is called once per frame
    void Update()
    
    {
        MoverNave();
        desplSpeed = variables_Objetos.velocidad;

       
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        if (vidaPlayer <= 0)
        {
            print("GAME OVER");
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Invoke("Morir", 3f);
            desplSpeed = 0;
            GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void MoverNave()
    {
        //Variables de movimiento y rotación
        float desplX = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");
        float desplR = Input.GetAxis("Rotar");
        //Variables de restricción de movimiento
        float posX = transform.position.x;
        float posY = transform.position.y;



       

        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);

        if ((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        }
        if ((posY > limiteVDown || desplV > 0f) && (posY < limiteVUp || desplV < 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplV, Space.World);
        }


        /*
         //La otra manera de restringir el movimiento
        transform.Translate(Vector3.right * Time.deltaTime * desplSpeed * desplX, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * desplSpeed * desplV, Space.World);
        float posX = transform.position.x;

        if (posX > limiteH && desplX > 0f)
        {
            transform.position = new  Vector3(posX, transform.position.y, transform.position.z);

        }
        if (posX < limiteH && desplX > 0f)
        {
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);

        }
        if (posY > limiteVDown && desplX > 0f)
        {
            transform.position = new Vector3( transform.position.x, posY, transform.position.z);

        }
        if (posY < limiteVDown && desplX > 0f)
        {
            transform.position = new Vector3( transform.position.x, posY, transform.position.z);

        }
        */
    }

    /* private void OnTriggerEnter(Collider other)
     {

         if (other.gameObject.layer == 16)
         {

             //variables_Objetos.velocidad = 0;
             if (vidas > 1)
             {
                 Variables.vidas--;
                 print("Has chocado contra un objeto");
             }
             else
             {
                 print("Game Over");
                 SceneManager.LoadScene(5);
                 //gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;

             }
         }
     }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 16)
        {
            print("DADO");
            vidaPlayer = vidaPlayer-30;
        }
        else if (other.gameObject.layer == 6)
        {
            print("vida");
            vidaPlayer = vidaPlayer + 30;
        }
    }
    void Morir()
    {
        SceneManager.LoadScene(3);
    }

}
