using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour,ISerializationCallbackReceiver
{
    public UserDataBase Userdata;
    public TextMeshProUGUI text;
    public Image UserImage;
    public void OnAfterDeserialize()
    {
         
    }

    public void OnBeforeSerialize()
    {
        if (UserImage != null)
            UserImage.sprite = Userdata.UserImage;
        if (text != null)
            text.text = Userdata.UserName;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
