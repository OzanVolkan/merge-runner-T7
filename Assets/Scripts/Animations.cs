using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public static Animations instance;

    public Animator playerAnimator;

    public GameObject winScreen;
    public GameObject winEffect;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (InputController.isMoving)
        {
            playerAnimator.SetBool("Run", true);
            playerAnimator.SetBool("Die", false);

        }
        else if (Obstacle.isDead)
        {
            playerAnimator.SetBool("Die", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            playerAnimator.SetBool("Dance", true);
            winScreen.SetActive(true);
            InputController.isMoving = false;
            winEffect.GetComponent<ParticleSystem>().Play();
        }
    }
}
