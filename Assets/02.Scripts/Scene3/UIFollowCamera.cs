using UnityEngine;

public class UIFollowCamera : MonoBehaviour
{
    private Transform mainCameraTransform;
    private Transform uiTransform;

    public Vector3 offset = new Vector3(0.0f, 0.0f, 1.0f);

    private void Start()
    {
        mainCameraTransform = Camera.main.transform;
        uiTransform = transform;
    }

    private void Update()
    {
        uiTransform.position = mainCameraTransform.position + mainCameraTransform.forward * offset.z +
                               mainCameraTransform.up * offset.y + mainCameraTransform.right * offset.x;
        uiTransform.rotation = mainCameraTransform.rotation;
    }
}
