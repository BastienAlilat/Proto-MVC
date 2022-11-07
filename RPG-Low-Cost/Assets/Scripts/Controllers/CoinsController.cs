using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC {
    public class CoinsController
    {
        public static CoinsModel coinsModel;
        public static event Action<CoinsModel> OnInit;

        public static void Init(DataCoins data)
        {
            coinsModel = new CoinsModel(data);
            OnInit?.Invoke(coinsModel);
        }
    }
}