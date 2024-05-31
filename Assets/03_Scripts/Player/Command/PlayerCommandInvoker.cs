using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerCommandInvoker
    {
        public enum Commands { MoveRight = 0, MoveLeft, MoveStop, Jump }
        private CommandBase[] commands;
        public PlayerCommandInvoker(PlayerController playerController)
        {
            commands = new CommandBase[4];
            commands[(int)Commands.MoveRight] = new PlayerMoveRightCommand(playerController.Movement);
            commands[(int)Commands.MoveLeft] = new PlayerMoveLeftCommand(playerController.Movement);
            commands[(int)Commands.MoveStop] = new PlayerMoveStopCommand(playerController.Movement);
            commands[(int)Commands.Jump] = new PlayerJumpCommand(playerController.Movement);
        }

        public void Execute(Commands command)
        {
            commands[(int)command].Execute();
        }
    }
}