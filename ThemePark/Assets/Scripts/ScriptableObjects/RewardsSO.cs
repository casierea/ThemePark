using System;
using Mapbox.Utils;
using UnityEngine;

[CreateAssetMenu]
public class RewardsSO : ElementsSO
{
    public float barCode;
    
    public void Set(String newName, String newFilter, String newWebsiteAddress, String newDescription, String newMenu,
        Sprite newIcon, Sprite newLogo, Sprite newPictures, float newBarCode)
    {
        name = newName;
        Name = newName;
        filter = newFilter;
        websiteAddress = newWebsiteAddress;
        description = newDescription;
        menu = newMenu;
        icon = newIcon;
        logo = newLogo;
        pictures = newPictures;
        barCode = newBarCode;
    }
}
