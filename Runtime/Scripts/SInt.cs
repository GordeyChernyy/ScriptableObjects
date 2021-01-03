using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptableVariables
{
    [CreateAssetMenu(menuName = "ScriptableVariables/SInt")]
    public class SInt : ScriptableObject
    {
        public int value;
        [Tooltip("Do you want this variable to be persistent across scenes? But !!! If scene 2 will have reference to this SInt it will stay the same more information here https://answers.unity.com/questions/1501743/scriptable-object-resets-randomly-between-scenes.html")]
        public bool isPersistent = false;
        public bool isClearOnEnable = true;

        private void OnEnable()
        {
            if (isPersistent) hideFlags = HideFlags.DontUnloadUnusedAsset;
            if (isClearOnEnable) value = 0;
        }

        public void Set(int value)
        {
            this.value = value;
        }
    }
}