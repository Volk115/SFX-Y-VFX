using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moove_Left : MonoBehaviour
{
    //VELOCIDAD A LA QUE SE MOVERA
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SE MOVERA CONSTANTEMENTE
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
    }
}
