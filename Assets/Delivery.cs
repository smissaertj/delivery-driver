using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] private float destroyDelay = 0.5f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package picked up!");
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered!");
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
