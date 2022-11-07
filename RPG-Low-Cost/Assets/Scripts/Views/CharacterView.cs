using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class CharacterView : MonoBehaviour
    {
        [SerializeField]
        Transform character;

        public static event Action<MovementDirection> OnPressMovement;

        // Start is called before the first frame update
        private void Awake()
        {
            CharacterController.OnUpdatePosition += UpdateDisplay;
        }

        private void Update()
        {
            ControlCharacter();
        }
        private void ControlCharacter()
        {
            if(Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.LeftArrow))
                OnPressMovement(MovementDirection.Left);
            else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
                OnPressMovement(MovementDirection.Right);
            else if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.UpArrow))
                OnPressMovement(MovementDirection.Up);
            else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
                OnPressMovement(MovementDirection.Down);
        }

        private void UpdateDisplay(Vector3 newPos)
        {
            Vector3 pos = new Vector3(Round(newPos.x), Round(newPos.y), Round(newPos.z));
            character.position = newPos;
            this.UpdateCamera(character.position);
        }

        void UpdateCamera(Vector3 pos)
        {
            if(pos.x < 12 && pos.x > -12)
                Camera.main.transform.position = new Vector3(pos.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
            if (pos.y < 8 && pos.y > -6)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, pos.y, Camera.main.transform.position.z);
        }

        float Round(float f)
        {
            return Mathf.Round(f*100)/100;
        }
    }
}