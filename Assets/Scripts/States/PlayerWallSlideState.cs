using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallSlideState : PlayerState
{
    public PlayerWallSlideState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (xInput != 0 && player.facingDir != xInput)
            stateMachine.ChangeState(player.airState);

        if(yInput < 0)
            player.SetVelocity(0, rb.linearVelocity.y);
        else
            player.SetVelocity(0, rb.linearVelocity.y * .9f);

        if (player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);
    }
}
