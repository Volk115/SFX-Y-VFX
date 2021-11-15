using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat_Back_Ground : MonoBehaviour
{
    //EL FONDO SE MOVERA CONSTANTEMENTE Y CUANDO DETECTE QUE HA LLEGADO AL LIMITE...
    //AL MOMENTO TOMARA LA POSICION INICIAL
    private Vector3 startPos;
    public float repeatWidht;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidht = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //repeatWith es la enchura e la imagen (sea la que sea)
        if (transform.position.x < startPos.x - repeatWidht)
        {
            transform.position = startPos;

        }
        
    }
}
