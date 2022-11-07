using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class Coin : MonoBehaviour
    {
        [SerializeField]
        SpriteRenderer coinImage;
        [SerializeField]
        Color mid;
        [SerializeField]
        Color high;

        public CoinData coinData;

        public void Init(CoinData display)
        {
            coinData = display;
            this.transform.position = coinData.position;
            
            if (coinData.coinValue == CoinValue.MID)
                coinImage.color = mid;
            if (coinData.coinValue == CoinValue.HIGH)
                coinImage.color = high;
            
        }
    }
}

