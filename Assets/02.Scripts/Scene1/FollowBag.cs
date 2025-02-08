using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBag : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float distance = 0.5f;

    void Update()
    {

        Vector3 targetPosition = FindTargetPosition();

        MoveTowards(targetPosition);

    }

    private Vector3 FindTargetPosition()
    {
        return cameraTransform.position + (cameraTransform.forward * distance) + (cameraTransform.right * 0.15f);
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        transform.position += (targetPosition - transform.position) * 0.025f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }
}
