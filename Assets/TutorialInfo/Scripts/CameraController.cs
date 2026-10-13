/************************************************************
* COMPONENT OF: Main Camera
* DESCRIPTION: Makes the camera follow the Player using an offset.
* AUTHOR: KaiHislop
* VERSION: 1.0
*************************************************************/

using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    // Updates after the player moves
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position + offset;
        }
    }
}