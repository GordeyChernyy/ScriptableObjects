using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptableVariables
{

    [CreateAssetMenu(menuName = "ScriptableVariables/SColor")]
    public class SColor : ScriptableObject
    {
        public Color value;
    }
}