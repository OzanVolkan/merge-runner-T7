using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject failScreen;
    public static bool isDead;
    private void OnTriggerEnter(Collider other)
    {
        isDead = true;
        failScreen.SetActive(true);
        InputController.isMoving = false;
    }
}
