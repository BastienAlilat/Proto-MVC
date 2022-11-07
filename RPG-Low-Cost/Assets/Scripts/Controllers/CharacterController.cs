using System;
using UnityEngine;

namespace MVC
{
    public enum MovementDirection
    {
        None,
        Left,
        Right,
        Up,
        Down
    }
    public static class CharacterController
    {
        public static CharacterModel characterModel;

        public static event Action<Vector3> OnUpdatePosition;
        public static event Action<int> OnUpdateCoins;

        public static void Init(DataMovement data)
        {
            CharacterView.OnPressMovement += UpdatePosition;
            CollisionCharacter.OnEnterCoin += UpdateCoins;
            characterModel = new CharacterModel(data);
            UpdatePosition(MovementDirection.None);
        }
        static void UpdatePosition(MovementDirection direction)
        {

            Vector3 newPos = characterModel.position;
            if (direction == MovementDirection.Left)
                newPos.x -= characterModel.movement.horizontal;
            if(direction == MovementDirection.Right)
                newPos.x += characterModel.movement.horizontal;
            if(direction == MovementDirection.Up)
                newPos.y += characterModel.movement.vertical;
            if (direction == MovementDirection.Down)
                newPos.y -= characterModel.movement.vertical;

            characterModel.UpdatePosition(newPos);
            OnUpdatePosition?.Invoke(characterModel.position);
        }

        static void UpdateCoins(CoinData coin)
        {
            characterModel.AddCoins(coin.GetValue());
            OnUpdateCoins?.Invoke(characterModel.coins);

        }
    }
}
