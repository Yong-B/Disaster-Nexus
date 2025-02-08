using UnityEngine;
using UnityEngine.SceneManagement;


//파티클 게임오버 ui와 씬전환과 행동 정지와 
public class ParticleUI : MonoBehaviour
{
    public GameObject particleSystem;
    public GameObject uiPrefab;
    public GameObject character; // 캐릭터 GameObject를 연결해주세요.
    public float sceneTransitionDelay = 5.0f; // 5초 후에 씬 전환

    private CharacterController characterController;
    private Vector3 originalCharacterPosition; // 원래 캐릭터 위치 저장
    private bool characterCanMove = true;

    private void Start()
    {
        uiPrefab.SetActive(false);
        characterController = character.GetComponent<CharacterController>();
        originalCharacterPosition = character.transform.position; // 초기 캐릭터 위치 저장
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrefab.SetActive(true);
            characterCanMove = false; // 캐릭터의 움직임을 멈춥니다.

            // sceneTransitionDelay 시간 후에 씬 전환을 시작합니다.
            Invoke("LoadNextScene", sceneTransitionDelay);
        }
    }

    private void Update()
    {
        if (!characterCanMove)
        {
            // 캐릭터의 움직임을 멈추고, 중력에 영향을 받지 않게 설정합니다.
            characterController.Move(Vector3.zero);
            characterController.SimpleMove(Vector3.zero);

            // 캐릭터의 위치를 원래 위치로 고정합니다.
            character.transform.position = originalCharacterPosition;
        }
    }

    private void LoadNextScene()
    {
        // 다음 씬으로 전환
        SceneManager.LoadScene("Shelter");
    }
}
