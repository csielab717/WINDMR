using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManipulationStep : MonoBehaviour
{
    GameObject stepLabelObject;

    TextMeshProUGUI stepText;

    List<string> stepStrings;
    int currentStep = 0;

    // Start is called before the first frame update
    void Start()
    {
        stepStrings = new List<string>();
        stepLabelObject = GameObject.Find("StepLabel");
        stepText = stepLabelObject.GetComponent<TextMeshProUGUI>();
        stepStrings.Add("Start");
        stepStrings.Add("Spin the knob to start the machine");
        stepStrings.Add("Check if the head of the wind drive generator is rotating");

        stepText.text = stepStrings[currentStep];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onNextDwellCompleted()
    {
        if (currentStep < stepStrings.Count-1)
        {
            currentStep++;
        }
        stepText.text = stepStrings[currentStep];
    }

    public void onPreviousDwellCompleted()
    {
        if (currentStep >0)
        {
            currentStep--;
        }
        stepText.text = stepStrings[currentStep];
    }
}
