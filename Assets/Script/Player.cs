using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Player : MonoBehaviour,ISerializationCallbackReceiver
{
    public UserDataBase Userdata;
    public Image UserImage;
    public void OnAfterDeserialize()
    {
         
    }

    public void OnBeforeSerialize()
    {
        if (UserImage != null)
            UserImage.sprite = Userdata.UserImage;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
