using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
   public static int vidas;
    public int velocidad;
    
  

    // Start is called before the first frame update
    void Start()
    {
        vidas = 6; 
        velocidad = 50;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Getlives()
    {
        int liveRest = vidas;
        return (liveRest);
    }
}
