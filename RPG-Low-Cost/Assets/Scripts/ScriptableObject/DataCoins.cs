using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataCoin", menuName = "MyGame/Coin Data")]

public class DataCoins : ScriptableObject
{
    public List<MVC.CoinData> dataCoinsList;
}
