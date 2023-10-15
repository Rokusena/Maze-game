using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int coinsCollected = 0;
    public GameObject FirstwallToDestroy;
    public GameObject FinalwallToDestroy;
    public TextMeshProUGUI textMeshProText;

    void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Coin"))
        {

            coinsCollected++;

            Destroy(other.gameObject);
            if (coinsCollected >= 1)
            {
                Destroy(FirstwallToDestroy);
            }
            if (coinsCollected >= 10)
            {
                Destroy(FinalwallToDestroy);
            }

        }
    }
    private void Update()
    {
        textMeshProText.text = ": " + coinsCollected; 
    }
}

