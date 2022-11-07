using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    [Serializable]
    public enum CoinValue
    {
        LOW,
        MID,
        HIGH
    }

    [Serializable]
    public struct CoinData
    {
        public Vector3 position;
        public CoinValue coinValue;

        public int GetValue()
        {
            if (coinValue == CoinValue.MID)
                return 5;
            if (coinValue == CoinValue.HIGH)
                return 10;
            return 1;
        }
    }
    public class CoinsModel
    {
        public List<CoinData> allCoins;

        public CoinsModel(DataCoins data)
        {
            this.allCoins = data.dataCoinsList;
        }
    }
}