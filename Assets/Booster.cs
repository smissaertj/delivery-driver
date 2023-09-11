using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 20f;
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }
}
