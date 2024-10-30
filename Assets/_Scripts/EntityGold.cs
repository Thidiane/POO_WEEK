using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextGold;
    [SerializeField] int gold;

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
        TextGold.text = "Gold : " + gold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            gold += 1;
            TextGold.text = "Gold : " + gold;
            WaitDestroy();
            Destroy(other.gameObject);
        }
        
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds (2);
    }
}
