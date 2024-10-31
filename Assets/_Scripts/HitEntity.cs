using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    EntityHealth entityHealth;
    [SerializeField]protected int AmountDamage = 10;
    [SerializeField] protected bool InTrigger;


    private void Awake()
    {
        
        entityHealth = GetComponent<EntityHealth>();
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InTrigger = true;
            entityHealth.TakeDamage(AmountDamage);
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InTrigger = false;
        }
    }
}
