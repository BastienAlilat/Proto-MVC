using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC;
public class Manager : MonoBehaviour
{
    [SerializeField]
    DataMovement dataMovement;
    [SerializeField]
    DataCoins dataCoins;
    void Awake()
    {
        MVC.CharacterController.Init(dataMovement);
        MVC.CoinsController.Init(dataCoins);
    }
}
