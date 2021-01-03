using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableVariables
{
    [CreateAssetMenu(menuName = "ScriptableVariables/SString")]
    public class SString : ScriptableObject
    {
        public string value;
        public delegate void OnChange(string value);
        public OnChange onStringChange;
        public void Set(string value)
        {
            this.value = value;
            onStringChange?.Invoke(value);
        }
        public void Subscribe(OnChange func)
        {
            onStringChange += func;
        }
        public void Unsubscribe(OnChange func)
        {
            onStringChange -= func;
        }
    }
}