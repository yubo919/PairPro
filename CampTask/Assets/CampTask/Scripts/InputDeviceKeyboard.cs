using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDeviceKeyboard : InputDeviceInterface
{
    KeyCode[] keyCodes = new KeyCode[(int)InputType.Max];

    public InputDeviceKeyboard()
    {
        keyCodes[(int)InputType.Up] = KeyCode.W;
        keyCodes[(int)InputType.Down] = KeyCode.S;
        keyCodes[(int)InputType.Left] = KeyCode.A;
        keyCodes[(int)InputType.Right] = KeyCode.D;
    }

    public bool GetDown(InputType type)
    {
        return Input.GetKeyDown(keyCodes[(int)type]);
    }

    public bool GetUp(InputType type)
    {
        return Input.GetKeyUp(keyCodes[(int)type]);
    }

    public bool Get(InputType type)
    {
        return Input.GetKey(keyCodes[(int)type]);
    }
}
