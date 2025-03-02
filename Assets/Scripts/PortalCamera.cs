using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portalA;
    public Transform portalB;

    void Update()
    {
        Vector3 offset = playerCamera.position - portalA.position;
        transform.position = portalB.position + offset;

        float angleDifference = Quaternion.Angle(portalA.rotation, portalB.rotation);
        Quaternion rotationDiff = Quaternion.AngleAxis(angleDifference, Vector3.up);
        Vector3 newForward = rotationDiff * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newForward, Vector3.up);
    }
}
