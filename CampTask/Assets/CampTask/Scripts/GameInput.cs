using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameInputType
{
    Forward,
    Back,
    Left,
    Right,
    Max
}

public class GameInput
{
    private List<InputDeviceInterface> _inputDevices = new List<InputDeviceInterface>();

    InputType[] inputTypes = new InputType[(int)GameInputType.Max];

    private static GameInput _instance = null;
    public static GameInput Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameInput();
            }
            return _instance;
        }
    }

    public GameInput()
    {
        _inputDevices.Add(new InputDeviceKeyboard());

        inputTypes[(int)GameInputType.Forward] = InputType.Up;
        inputTypes[(int)GameInputType.Back] = InputType.Down;
        inputTypes[(int)GameInputType.Left] = InputType.Left;
        inputTypes[(int)GameInputType.Right] = InputType.Right;
    }

    public bool GetDown(GameInputType type)
    {
        bool isDown = false;
        for (int i = 0; i < _inputDevices.Count; i++)
        {
            isDown = _inputDevices[i].GetDown((inputTypes[(int)type]));
        }
        return isDown;
    }

    public bool GetUp(GameInputType type)
    {
        bool isUp = false;
        for (int i = 0; i < _inputDevices.Count; i++)
        {
            isUp = _inputDevices[i].GetUp((inputTypes[(int)type]));
        }
        return isUp;
    }

    public bool GetStay(GameInputType type)
    {
        bool isStay = false;
        for (int i = 0; i < _inputDevices.Count; i++)
        {
            isStay = _inputDevices[i].GetUp((inputTypes[(int)type]));
        }
        return isStay;
    }
}
