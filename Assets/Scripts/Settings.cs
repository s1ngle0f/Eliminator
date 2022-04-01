using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Settings : ScriptableObject
{
    [SerializeField] private List<double> probabilityOfLossOfCars;
    public List<double> ProbabilityOfLossOfCars => probabilityOfLossOfCars;
    [Space]
    [SerializeField] private double allProcents;
    #if UNITY_EDITOR
    private void OnValidate()
    {
        if (probabilityOfLossOfCars.Count > 0)
        {
            allProcents = 0;
            foreach (double i in probabilityOfLossOfCars)
                allProcents += i;
        }
    }
    #endif
}
