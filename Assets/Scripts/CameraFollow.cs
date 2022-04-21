using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followObject;
    [SerializeField] private Vector3 range;
    private void LateUpdate()
    {
        transform.position = followObject.transform.position + range;
    }
}
