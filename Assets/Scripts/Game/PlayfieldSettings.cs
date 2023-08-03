using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Overdrive/Data/Playfield Settings")]
public class PlayfieldSettings : ScriptableObject {
    public Vector2 TopLeftCorner;
    public Vector2 BottomRightCorner;
}
