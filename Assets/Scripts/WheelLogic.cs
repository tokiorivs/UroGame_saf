using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.PickerWheelUI;
using UnityEngine.UI;
using TMPro;

public class WheelLogic : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] TextMeshProUGUI spinTextButton;
    [SerializeField] Button spinButton;
    [SerializeField] PickerWheel pickerWheel;
    // Start is called before the first frame update
    void Start()
    {
        spinButton.onClick.AddListener (() => {
           spinButton.interactable = false;
           spinTextButton.text = "Girando";

           pickerWheel.OnSpinStart(()=> Debug.Log("el giro a comenzado"));

           pickerWheel.OnSpinEnd(wheelPiece =>{
            Debug.Log("Spin end: Label:" + wheelPiece.Label + "Amount" + wheelPiece.Amount );
            spinButton.interactable = true;
            spinTextButton.text = "presiona para jugar";
           });
           pickerWheel.Spin();
        });
        
    }
}
