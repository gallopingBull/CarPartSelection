using UnityEngine;

[CreateAssetMenu(fileName = "CarPartData", menuName = "ScriptableObjects/CarPart", order = 1)]
public class CarPartData : ScriptableObject
{
    public string PanelCarPartTitle;
    [TextArea]
    public string PanelCarPartDescription;
}


