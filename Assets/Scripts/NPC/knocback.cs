using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knocback : MonoBehaviour
{
    public void ApplyKnockback(Transform target, float force)
    {
        Vector3 knockbackDirection = (target.position - transform.position).normalized;
        Rigidbody2D targetRigidbody = target.GetComponent<Rigidbody2D>();

        if (targetRigidbody != null)
        {
            targetRigidbody.velocity = Vector2.zero;
            targetRigidbody.AddForce(knockbackDirection * force, ForceMode2D.Impulse);
        }
    }
}
