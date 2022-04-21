using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerChangeSize : MonoBehaviour
{
    public float changeSize = 1f;
    public static float scoreCounter;

    private void Start()
    {
        scoreCounter = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Right") || other.CompareTag("Left"))
        {
            scoreCounter++;
            changeSize = changeSize + .025f;
            PlayerCore.instance.midPlayer.transform.localScale = PlayerCore.instance.midPlayer.transform.localScale * changeSize;

            Destroy(gameObject);
        }
    }
}
