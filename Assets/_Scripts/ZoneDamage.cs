using UnityEngine;
using UnityEngine.UI;

public class ZoneDamage : HitEntity
{
    

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Debug.Log("PV-");
        
    }
}
