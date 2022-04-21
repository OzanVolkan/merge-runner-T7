using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    public static PlayerCore instance;

    public GameObject midPlayer;
    public GameObject divideEffect;
    void Start()
    {
        instance = this;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Left"))
        {
            other.gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
            this.gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
            other.gameObject.tag = "Untagged";
            this.gameObject.tag = "Untagged";

            midPlayer.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;
        this.gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;
        other.gameObject.tag = "Left";
        this.gameObject.tag = "Right";

        midPlayer.SetActive(false);
        divideEffect.GetComponent<ParticleSystem>().Play();
    }
}
