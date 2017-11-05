using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IUnit
    {
        void Spaw (Vector3 position);
        void Die ();
        void TakeItem (object item);
        void TakeDamage (float amount);
    }
}
