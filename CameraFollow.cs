using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -10);
    public float rotationSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        // Rotate with mouse
        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
        target.Rotate(0, horizontal, 0);

        // Follow the target
        transform.position = target.position + target.rotation * offset;
        transform.LookAt(target);
    }
}

