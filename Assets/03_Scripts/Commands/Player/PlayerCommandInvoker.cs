using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class PlayerCommandInvoker : MonoBehaviour
    {
        public void ExecuteCommand(Command command)
        {
            command.Execute();
        }
    }
}
