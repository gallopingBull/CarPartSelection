using TMPro;
using UnityEngine;

public class DisplayDescriptionPanel : MonoBehaviour
{
    [SerializeField] CarDatabase _carDatabase;
    private GameObject _descriptionDisplay;
    private TextMeshProUGUI _titeText;
    private TextMeshProUGUI _descriptionText;

    private void Start()
    {
        _descriptionDisplay = GameObject.Find("Panel_PartDescriptionDisplay");
        _titeText = GameObject.Find("Text_PartDescriptionTitle").GetComponent<TextMeshProUGUI>();
        _descriptionText= GameObject.Find("Text_PartDescription").GetComponent<TextMeshProUGUI>();
        HidePanel();
    }

    void OnEnable()
    {
        SelectionController.OnObjectSelected += DisplayPanel;
        SelectionController.OnObjectDeSelected += HidePanel;
    }
    void OnDisable()
    {
        SelectionController.OnObjectSelected -=  DisplayPanel;
        SelectionController.OnObjectDeSelected -= HidePanel;
    }


    public void DisplayPanel(string name)
    {
        if (_descriptionDisplay.activeSelf)
            _descriptionDisplay.SetActive(false);
        InitPanelData(name);
        _descriptionDisplay.SetActive(true);
    }

    private void HidePanel()
    {
        _descriptionDisplay.SetActive(false);
    }
    private void InitPanelData(string partName)
    {
       CarPartData partData = _carDatabase.GetCarPartData(partName);
       if (partData == null)
           return;
       _titeText.text = partData.PanelCarPartTitle;
        _descriptionText.text = partData.PanelCarPartDescription;
    }
}
