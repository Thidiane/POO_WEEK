using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth =  100;

    public int CurrentHealth;


    private void Awake()
    {
        
        _maxHealth = 100;
    }

    private void Start()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
            Debug.Log("mort");
        }
        Debug.Log("Current Health: " + CurrentHealth);
    }

}
