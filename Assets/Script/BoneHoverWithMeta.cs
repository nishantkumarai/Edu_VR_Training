using UnityEngine;
using TMPro;
using Oculus.Interaction;

public class BoneHoverWithMeta : MonoBehaviour
{
    [Header("Ray Settings")]
    public Transform rayOrigin; // Set this to the controller's ray origin
    public float rayLength = 10f; // Adjust the ray length
    public LayerMask boneLayer; // Layer mask to filter bone objects

    [Header("UI Settings")]
    public TMP_Text boneNameText; // TextMeshPro element to display the bone name

    private void Update()
    {
        // Create a ray from the controller
        Ray ray = new Ray(rayOrigin.position, rayOrigin.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, rayLength, boneLayer))
        {
            // Display the name of the hovered bone
            boneNameText.text = hit.collider.gameObject.name;
        }
        else
        {
            // Clear the UI when no bone is hovered
            boneNameText.text = "";
        }
    }
}
