using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionState{
	Walk = 0,
	Run,
	Squad,
	Down,
	Jump,
	Max
}

public class NewPlayer : MonoBehaviour,IPlayer {

	[SerializeField]
	PlayerController _PlayerController;

	private ActionStateBase[] _ActionStateList = new ActionStateBase[(int)ActionState.Max];
	private ActionState _CurrentState = ActionState.Walk;

	// Use this for initialization
	void Start () {
		_ActionStateList [(int)ActionState.Walk] = new ActionStateWalk ();
		_ActionStateList [(int)ActionState.Run] = new ActionStateWalk ();
		_ActionStateList [(int)ActionState.Jump] = new ActionStateWalk ();
		_ActionStateList [(int)ActionState.Squad] = new ActionStateWalk ();
		_ActionStateList [(int)ActionState.Down] = new ActionStateWalk ();
		foreach (var _action in _ActionStateList)
		{
			_action._Iplayer = this;
		}

		_ActionStateList [(int)_CurrentState].OnEnter ();
	}
	
	// Update is called once per frame
	void Update () {
		_ActionStateList [(int)_CurrentState].Update ();
	}

	public void ChangeState(ActionState actionState)
	{
		if (_CurrentState == actionState)
		{
			return;
		}
		_ActionStateList [(int)_CurrentState].OnExit ();
		_CurrentState = actionState;
		_ActionStateList [(int)_CurrentState].OnEnter ();
	}
}
