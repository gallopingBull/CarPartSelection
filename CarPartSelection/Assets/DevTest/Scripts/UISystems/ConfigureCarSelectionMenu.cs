using System.Linq;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ConfigureCarSelectionMenu : MonoBehaviour
{
    [SerializeField] CarDatabase _carDatabase;
    [SerializeField] GameObject _butPrefab;
    private GameObject _carSelectionMenu;

    void Start()
    {
        _carSelectionMenu = GameObject.Find("Panel_CarPartSelections");
        InitMenu();
    }

    private void InitMenu()
    {
        if (_carDatabase == null)
            return;

        int carPartsTotal = _carDatabase.CarPartDatas.Count;
        
        for (int i = 0; i < carPartsTotal; i++)
        {
            Debug.Log(i);
            var tmp = Instantiate(_butPrefab, _carSelectionMenu.transform);
            string name = _carDatabase.CarPartDatas.ElementAt(i).PanelCarPartTitle;
            tmp.GetComponentInChildren<TextMeshProUGUI>().text = name;
            tmp.GetComponent<Button>().onClick.AddListener(() => GetComponent<DisplayDescriptionPanel>().DisplayPanel(name));
        }
    }
}
