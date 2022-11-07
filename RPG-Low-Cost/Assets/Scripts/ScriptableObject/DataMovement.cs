using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataMovement", menuName = "MyGame/Movement Data")]
public class DataMovement : ScriptableObject
{
    public Vector3 position;
    public MVC.Movement movement;
}
