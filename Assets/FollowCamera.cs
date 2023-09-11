using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The camera's position should be the same as the deliveryCar's position.
    [SerializeField] private GameObject objectToFollow;
    private void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
