using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    EntityHealth entityHealth;
    [SerializeField]protected int AmountDamage = 10;
    [SerializeField] protected bool InTrigger; 

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InTrigger = true;
            entityHealth.TakeDamage(10);
        }
    }

    public void TakeDamage()
    {
        
    }
}
