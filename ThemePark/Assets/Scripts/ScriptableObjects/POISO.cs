using System;
using Mapbox.Utils;
using UnityEngine;

[CreateAssetMenu]
public class POISO : ElementsSO
{
    public Vector2d location;
    public Color colorCode, borderColor;

    public void Set(String newName, String newFilter, String newWebsiteAddress, String newDescription, String newMenu,
        Sprite newIcon, Sprite newLogo, Sprite newPictures, Vector2d newLocation, Color newColorCode,
        Color newBorderColor)
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
        location = newLocation;
        colorCode = newColorCode;
        borderColor = newBorderColor;
    }

    public void Set(POISO newInfo)
    {
        name = newInfo.name;
        Name = newInfo.Name;
        filter = newInfo.filter;
        websiteAddress = newInfo.websiteAddress;
        description = newInfo.description;
        menu = newInfo.menu;
        icon = newInfo.icon;
        logo = newInfo.logo;
        pictures = newInfo.pictures;
        location = newInfo.location;
        colorCode = newInfo.colorCode;
        borderColor = newInfo.borderColor;
    }
}
