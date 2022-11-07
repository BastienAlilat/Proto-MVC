using System;
using System.Collections;
using UnityEngine;

namespace MVC
{
        [Serializable]
        public struct Movement
        {
            public float vertical;
            public float horizontal;

            public Movement(float v, float h)
            {
                vertical = v;
                horizontal = h;
            }
        }
    public class CharacterModel
    {
        public int coins
        {
            get;
            private set;
        }
        public Vector3 position
        {
            get;
            private set;
        }
        public Movement movement
        {
            get;
            private set;
        }

        public CharacterModel(DataMovement data)
        {
            this.LoadData(data);
        }


        public void UpdatePosition(Vector3 v)
        {
            position = v;
        }
        public void AddCoins(int coinsAdded)
        {
            coins += coinsAdded;
        }

        private void LoadData(DataMovement data)
        {
            if (string.IsNullOrEmpty(PlayerPrefs.GetString("characterPos")))
            {
                position = data.position;
            }
            else
            {
                string pos = PlayerPrefs.GetString("characterPos", "0.6 0.4 -0.5");
                string[] vs = pos.Split(' ');
                position = new Vector3(float.Parse(vs[0]), float.Parse(vs[1]), float.Parse(vs[2]));
            }

            if (string.IsNullOrEmpty(PlayerPrefs.GetString("characterMovement")))
            {
                movement = data.movement;
            }
            else
            {
                string mov = PlayerPrefs.GetString("characterMovement", "1.2 1.2");
                string[] vs = mov.Split(' ');
                movement = new Movement(float.Parse(vs[0]), float.Parse(vs[1]));
            }

            coins = PlayerPrefs.GetInt("characterCoins", 0);
        }

        public void SaveData()
        {
            string savePos = position.x + " " + position.y + " " + position.z;
            PlayerPrefs.SetString("characterPos", savePos);
            string saveMov = movement.vertical + " " + movement.horizontal;
            PlayerPrefs.SetString("characterMovement", saveMov);

            PlayerPrefs.SetInt("characterCoins", coins);
        }
    }
}
