using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MVC
{
    public class CoinsViewUI : MonoBehaviour
    {
        [SerializeField]
        TextMeshProUGUI coinsCount;

        private void Awake()
        {
            CharacterController.OnUpdateCoins += UpdateDisplay;
        }
        private void UpdateDisplay(int coins)
        {
            coinsCount.text = coins.ToString();
        }

    }
}
