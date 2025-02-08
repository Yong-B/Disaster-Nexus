using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform; // 카메라의 위치와 방향을 나타내는 Transform 변수
    [SerializeField] private float distance = 0.2f; // 카메라로부터의 거리

    private bool isCentered = false; // 오브젝트가 카메라 중앙에 위치하는지 여부를 나타내는 변수

    private Quaternion initialRotation; // 초기 회전값을 저장하는 변수

    private void OnBecameInvisible()
    {
        isCentered = false; // 오브젝트가 화면에서 사라지면 중앙에 위치하지 않음을 표시
    }

    void Start()
    {
        initialRotation = transform.rotation; // 초기 회전값 저장
    }

    void Update()
    {
        if (!isCentered)
        {
            Vector3 targetPosition = FindTargetPosition(); // 중앙으로 이동할 목표 위치 계산

            MoveTowards(targetPosition); // 목표 위치로 이동

            if (ReachedPosition(targetPosition))
                isCentered = false; // 목표 위치에 도달하면 중앙에 위치하지 않음을 표시
        }

        RotateToCamera(); // 방독면을 카메라에 맞게 회전
    }

    private Vector3 FindTargetPosition()
    {
        // 카메라의 위치에서 카메라가 향하는 방향으로 distance만큼 떨어진 위치 계산
        return cameraTransform.position + (cameraTransform.forward * distance);
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        // 현재 위치에서 목표 위치로 일정 비율(0.1f)만큼 이동하여 더 빠른 이동 속도 구현
        transform.position += (targetPosition - transform.position) * 0.2f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        // 현재 위치와 목표 위치 사이의 거리가 0.1f보다 작으면 true를 반환하여 목표 위치에 도달했음을 나타냄
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }

    private void RotateToCamera()
    {
        // 초기 회전값을 유지하면서 카메라를 바라보지 않도록 방향만 조정
        transform.rotation = Quaternion.LookRotation(cameraTransform.forward, Vector3.up) * initialRotation;
    }
}