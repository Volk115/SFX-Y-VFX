using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moove_Left : MonoBehaviour
{
    //VELOCIDAD A LA QUE SE MOVERA
    public float speed = 10f;
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent();
    }

    // Update is called once per frame
    void Update()
    {


        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        //SI EL OBSCTAULO SOBREPASA EL -1 EN Y, SE DESTRUIRA
        if (transform.position.y <= -1)
        {
            Destroy(gameObject);
        }
    }
}
