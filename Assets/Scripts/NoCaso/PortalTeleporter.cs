using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public Transform exitPortal;

    private void OnTriggerEnter(Collider other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller)
        {
            Vector3 localOffset = transform.InverseTransformPoint(other.transform.position);
            Vector3 newWorldPos = exitPortal.TransformPoint(localOffset);

            Quaternion rotationDiff = Quaternion.FromToRotation(transform.forward, exitPortal.forward);
            Vector3 newForward = rotationDiff * other.transform.forward;

            other.transform.SetPositionAndRotation(newWorldPos, Quaternion.LookRotation(newForward, Vector3.up));
        }
    }
}
