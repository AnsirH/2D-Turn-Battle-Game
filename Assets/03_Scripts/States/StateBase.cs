using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public abstract class StateBase<T> where T : Component
    {
        public abstract void Operation_Update(T entity);

        public abstract void Operation_FixedUpdate(T entity);

        public abstract void Enter(T entity);

        public abstract void Exit(T entity);
    }
}