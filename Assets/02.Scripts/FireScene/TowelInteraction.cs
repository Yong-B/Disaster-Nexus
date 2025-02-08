using UnityEngine;

public class TowelInteraction : MonoBehaviour
{
    public GameObject dryTowel;
    public GameObject wetTowel;
    private bool isWet = false;

    private void Start()
    {
        // 처음에는 건조한 수건이 활성화되어야 합니다.
        dryTowel.SetActive(true);
        wetTowel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 물 파티클과 충돌 시 젖은 수건으로 변경
        if (other.CompareTag("WaterParticle"))
        {
            if (!isWet)
            {
                // 손에서 잡은 dryTowel 오브젝트의 위치와 회전을 저장
                Vector3 dryTowelPosition = dryTowel.transform.position;
                Quaternion dryTowelRotation = dryTowel.transform.rotation;

                dryTowel.SetActive(false);
                wetTowel.SetActive(true);
                isWet = true;

                // wetTowel을 dryTowel이 있던 위치와 회전으로 이동
                wetTowel.transform.position = dryTowelPosition;
                wetTowel.transform.rotation = dryTowelRotation;
            }
        }
    }


}