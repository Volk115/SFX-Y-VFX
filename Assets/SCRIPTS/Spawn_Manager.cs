using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn_Manager : MonoBehaviour
{
    //RESPAWN DEL OBJETO PREFAB ASIGNADO
    public GameObject[] obstaclePrefab;
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;
    private Vector3 spawnPos = new Vector3(35, 0, 0);
    public PlayerController playerControllerScript;
    private int randomObj;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Spawner()
    {
        //SE MOVERA CONSTANTEMENTE PERO SI COLISIONA, SE DETENDRA
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab[randomObj], spawnPos, obstaclePrefab[randomObj].transform.rotation);
        }

        randomObj = Random.Range(0, 3);
    }
} 


