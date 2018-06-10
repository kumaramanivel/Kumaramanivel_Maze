using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinPoof;
    private static int coinsCollected = 0;

    public int CoinsCollected
    {
        get { return coinsCollected; }
        set { coinsCollected = value; }
    }

    public void OnCoinClicked()
    {
        // Use gameObject.transform.position directly ( it is a Vector3! )
        Instantiate(coinPoof, gameObject.transform.position, Quaternion.Euler(-100f, 0, 0));
        CoinsCollected++;
        Destroy(gameObject);
    }
}