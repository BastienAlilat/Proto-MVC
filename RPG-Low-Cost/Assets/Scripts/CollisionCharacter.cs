using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC {
    public class CollisionCharacter : MonoBehaviour
    {

        public static event Action<CoinData> OnEnterCoin;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("<color=yellow>OnCollisionEnter2D</color>");
            if (collision.transform.tag == "Coin")
            {
                Coin coin = collision.gameObject.GetComponent<Coin>();
                Destroy(collision.gameObject);
                OnEnterCoin?.Invoke(coin.coinData);
            }
        }
    }
}
