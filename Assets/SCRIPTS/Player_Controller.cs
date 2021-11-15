using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    //Fuerza del salto
    public float junpForce = 500;

    //Gravedad que afecta al sujeto
    public float gravityModifier = 1;

    //Detecta que toca tierra (o suelo)
    public bool isOnTheGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //gradevad y salto
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        
    }

    // Update is called once per frame
    void Update()
    { //para el salto y para que no salte mas de la cuenta
      //(se tiene en cuenta el peso del sujeto, la gravedad y la fuerza del salto)
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * junpForce, ForceMode.Impulse);
            isOnTheGround = false;

        }
        
    }
    //SI EL SUJETO COLISIONA CON UN OBJETO, EL SUJETO YA NO SALTA MAS
    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("GROUND"))
        {
            isOnTheGround = true;

            
        }
        else if (otherCollider.gameObject.ComparateTag("Obstacle"))
        {

            Debug.Log(message: "GAME OVER");
            Time.timeScale = 0;
        }




    }

}
