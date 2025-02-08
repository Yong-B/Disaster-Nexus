using UnityEngine;

public class CharacterGravity : MonoBehaviour
{
    public float gravity = 9.81f;
    private CharacterController characterController;

private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!characterController.isGrounded)
        {
            // 캐릭터가 땅에 있지 않을 때 중력 적용
            characterController.Move(Vector3.down * gravity * Time.deltaTime);
        }
    }
}