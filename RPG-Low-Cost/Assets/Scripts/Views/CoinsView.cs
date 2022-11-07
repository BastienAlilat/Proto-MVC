using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MVC
{
    public class CoinsView : MonoBehaviour
    {
        [SerializeField]
        Transform coinsContainer;
        [SerializeField]
        Coin coinObject;


        private void Awake()
        {
            CoinsController.OnInit += Init;
        }
        public void Init(CoinsModel coinsModel)
        {
            foreach(CoinData coinData in coinsModel.allCoins)
            {
                Coin newCoin = Instantiate(coinObject, coinsContainer);
                newCoin.Init(coinData);
            }
        }
    }
}