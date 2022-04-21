using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    [SerializeField] private Transform rightPlayerTransform;
    [SerializeField] private Transform leftPlayerTransform;
    [SerializeField] private Transform actualTransform;


    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rightMovementLimit = 4f;
    [SerializeField] private float movementSensitivity = 90f;

    public static bool isMoving;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 rightPos = rightPlayerTransform.position;
        Vector3 leftPos = leftPlayerTransform.position;

        rightPos.x = Mathf.Clamp(rightPos.x + (eventData.delta.x / movementSensitivity),0, rightMovementLimit);
        rightPlayerTransform.position = rightPos;

        leftPos.x = -rightPos.x;
        leftPlayerTransform.position = leftPos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    void Update()
    {
        if (isMoving)
        {
            actualTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else if (!isMoving)
        {
            actualTransform.Translate(Vector3.zero);
        }
    }
}
