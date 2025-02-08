using UnityEngine;
using UnityEngine.SceneManagement;


//��ƼŬ ���ӿ��� ui�� ����ȯ�� �ൿ ������ 
public class ParticleUI : MonoBehaviour
{
    public GameObject particleSystem;
    public GameObject uiPrefab;
    public GameObject character; // ĳ���� GameObject�� �������ּ���.
    public float sceneTransitionDelay = 5.0f; // 5�� �Ŀ� �� ��ȯ

    private CharacterController characterController;
    private Vector3 originalCharacterPosition; // ���� ĳ���� ��ġ ����
    private bool characterCanMove = true;

    private void Start()
    {
        uiPrefab.SetActive(false);
        characterController = character.GetComponent<CharacterController>();
        originalCharacterPosition = character.transform.position; // �ʱ� ĳ���� ��ġ ����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrefab.SetActive(true);
            characterCanMove = false; // ĳ������ �������� ����ϴ�.

            // sceneTransitionDelay �ð� �Ŀ� �� ��ȯ�� �����մϴ�.
            Invoke("LoadNextScene", sceneTransitionDelay);
        }
    }

    private void Update()
    {
        if (!characterCanMove)
        {
            // ĳ������ �������� ���߰�, �߷¿� ������ ���� �ʰ� �����մϴ�.
            characterController.Move(Vector3.zero);
            characterController.SimpleMove(Vector3.zero);

            // ĳ������ ��ġ�� ���� ��ġ�� �����մϴ�.
            character.transform.position = originalCharacterPosition;
        }
    }

    private void LoadNextScene()
    {
        // ���� ������ ��ȯ
        SceneManager.LoadScene("Shelter");
    }
}
