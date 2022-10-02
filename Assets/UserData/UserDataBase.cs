using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New User", menuName = "CreateUser/User")]
public class UserDataBase : ScriptableObject
{
    public int UserId;
    public string UserName;
    public Sprite UserImage;
}
