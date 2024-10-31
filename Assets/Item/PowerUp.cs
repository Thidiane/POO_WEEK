using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    PlayerMove playermove;
    protected override void Effect()
    {
        base.Effect();
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Effect();
        }
    }
    
}
