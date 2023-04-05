using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using ChatGPTWrapper;
using Sirenix.OdinInspector;
public class test : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;
    [SerializeField]
    private TMP_InputField _inputField;
    [SerializeField]
    private ChatGPTConversation _chatGPTConversation;
    public UnityStringEvent chatGPTResponse = new UnityStringEvent();
    private void Awake() {
        SetText("Hello World");
        
    }

    private void Update(){
    }

    public void SetText(string str)
    {
        _text.text = str;
    }

    public void SendChatGPTMessage()
    {
        chatGPTResponse.Invoke(_inputField.text);
    }

}
