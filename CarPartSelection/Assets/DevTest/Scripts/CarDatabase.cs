using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "CarDatabase", menuName = "ScriptableObjects/CarDatabase", order = 1)]
public class CarDatabase : ScriptableObject
{
    [SerializeField]
    public List<CarPartData> CarPartDatas;

    public CarPartData GetCarPartData(string partName)
    {
        CarPartData carPartData;
        for (int i = 0; i < CarPartDatas.Count; i++)
        {
            carPartData = CarPartDatas.ElementAt(i);
            // very hacky way to call camera - sorry! 
            if (carPartData.PanelCarPartTitle == partName)
            {
                CameraManager.camManager.ChangeCamera(i);
                return carPartData;
            }
        }
        return null;
        //return  CarPartDatas.Find(carPartData =>carPartData.PanelCarPartTitle == partName);
    }
}
