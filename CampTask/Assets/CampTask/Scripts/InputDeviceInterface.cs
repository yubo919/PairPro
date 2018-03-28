using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputType
{
    Up,
    Down,
    Left,
    Right,
    Max,
}


public interface InputDeviceInterface
{
    bool GetDown(InputType type);
    bool GetUp(InputType type);
    bool Get(InputType type);
}
