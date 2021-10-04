using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    [SerializeField] GameObject cuboPrefab;
    [SerializeField] Transform intiPos;
    float desp1x = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 destPos = intiPos.position;
        Vector3 desp1 = new Vector3(desp1x, 0, 0);
        for (int n = 0; n < 10; n++)
        {
            Instantiate(cuboPrefab, destPos, Quaternion.identity);
            destPos = destPos + desp1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
