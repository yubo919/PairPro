using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionStateWalk : ActionStateBase {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_Iplayer.ChangeState (ActionState.Run);
	}
}
