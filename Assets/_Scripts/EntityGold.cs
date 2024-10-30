using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] TextMeshPro TextGold;
    [SerializeField] int gold;

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gold ++;
        }
    }
}
