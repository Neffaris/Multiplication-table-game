using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textFieldWithMathOperation;
    [SerializeField] TMP_InputField _inputFieldWithAnswer;

    int _number1, _number2, _result;

    void Start()
    {
        ShowOperation();
    }
    int GenerateRandomNumber()
    {
        int _randomNumber = Random.Range(1, 11);
        return _randomNumber;
    }

    void GenerateOperation()
    {
        _number1 = GenerateRandomNumber();
        _number2 = GenerateRandomNumber();
        _result = _number1 * _number2;
    }

    string GetAnswerFromUser()
    {
        return _inputFieldWithAnswer.text;
    }    

    public void CheckAnswer()
    {
        if(_result.ToString() == GetAnswerFromUser())
        {
            Debug.Log("OK");
            ShowOperation();
        }
        else
        {
            Debug.Log("Error");
        }
        _inputFieldWithAnswer.text = "";
        ActivateInputField();
    }

    void ShowOperation()
    {
        GenerateOperation();
        _textFieldWithMathOperation.text = _number1 + " x " + _number2 + " = ";
        ActivateInputField();
    }

    void ActivateInputField()
    {
        _inputFieldWithAnswer.ActivateInputField();
    }

}
