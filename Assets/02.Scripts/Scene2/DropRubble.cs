using UnityEngine;

public class DropRubble : MonoBehaviour
{
    public Rigidbody objectBRigidbody; // B ������Ʈ�� Rigidbody
    public Rigidbody objectCRigidbody; // C ������Ʈ�� Rigidbody
    public AudioClip dropSound; // ����� �Ҹ� Ŭ��
    private AudioSource audioSource; // ����� �ҽ� ������Ʈ

    private void Start()
    {
        // ����� �ҽ� ������Ʈ ��������
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // B ������Ʈ�� C ������Ʈ�� Rigidbody�� �߷� ����� Ȱ��ȭ
            objectBRigidbody.useGravity = true;
            objectCRigidbody.useGravity = true;

            // ������ ����� Ŭ�� ���
            audioSource.clip = dropSound;
            audioSource.Play();
        }
    }
}