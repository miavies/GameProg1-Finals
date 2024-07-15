using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Teleporter : MonoBehaviour
{
   
    public Transform playerDestination; 
    public Transform cameraDestination;
    GameObject player;
    GameObject mainCamera;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = playerDestination.transform.position;
            player.transform.rotation = playerDestination.transform.rotation;

            mainCamera.transform.position = cameraDestination.transform.position;
            mainCamera.transform.rotation = cameraDestination.transform.rotation;

            Debug.Log("Tite");
        }
    }
}
