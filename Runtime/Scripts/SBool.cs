using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableVariables
{

    [CreateAssetMenu(menuName = "ScriptableVariables/SBool")]
    public class SBool : ScriptableObject
    {
        public bool value;
        public void Set(bool value)
        {
            this.value = value;
        }
    }
}