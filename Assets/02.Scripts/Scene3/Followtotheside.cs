using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform; // ī�޶��� ��ġ�� ������ ��Ÿ���� Transform ����
    [SerializeField] private float distance = 0.2f; // ī�޶�κ����� �Ÿ�

    private bool isCentered = false; // ������Ʈ�� ī�޶� �߾ӿ� ��ġ�ϴ��� ���θ� ��Ÿ���� ����

    private Quaternion initialRotation; // �ʱ� ȸ������ �����ϴ� ����

    private void OnBecameInvisible()
    {
        isCentered = false; // ������Ʈ�� ȭ�鿡�� ������� �߾ӿ� ��ġ���� ������ ǥ��
    }

    void Start()
    {
        initialRotation = transform.rotation; // �ʱ� ȸ���� ����
    }

    void Update()
    {
        if (!isCentered)
        {
            Vector3 targetPosition = FindTargetPosition(); // �߾����� �̵��� ��ǥ ��ġ ���

            MoveTowards(targetPosition); // ��ǥ ��ġ�� �̵�

            if (ReachedPosition(targetPosition))
                isCentered = false; // ��ǥ ��ġ�� �����ϸ� �߾ӿ� ��ġ���� ������ ǥ��
        }

        RotateToCamera(); // �浶���� ī�޶� �°� ȸ��
    }

    private Vector3 FindTargetPosition()
    {
        // ī�޶��� ��ġ���� ī�޶� ���ϴ� �������� distance��ŭ ������ ��ġ ���
        return cameraTransform.position + (cameraTransform.forward * distance);
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        // ���� ��ġ���� ��ǥ ��ġ�� ���� ����(0.1f)��ŭ �̵��Ͽ� �� ���� �̵� �ӵ� ����
        transform.position += (targetPosition - transform.position) * 0.2f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        // ���� ��ġ�� ��ǥ ��ġ ������ �Ÿ��� 0.1f���� ������ true�� ��ȯ�Ͽ� ��ǥ ��ġ�� ���������� ��Ÿ��
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }

    private void RotateToCamera()
    {
        // �ʱ� ȸ������ �����ϸ鼭 ī�޶� �ٶ��� �ʵ��� ���⸸ ����
        transform.rotation = Quaternion.LookRotation(cameraTransform.forward, Vector3.up) * initialRotation;
    }
}