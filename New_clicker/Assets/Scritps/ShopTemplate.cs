using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class ShopTemplate : MonoBehaviour
{
    public TMP_Text titleText;
    [FormerlySerializedAs("DescriptionTXT")] public TMP_Text descriptionTxt;
    public TMP_Text rockTxt;
    public TMP_Text woodTxt;
    public TMP_Text woolTxt;
    public TMP_Text ironTxt;
    public TMP_Text ropeTxt;
    public TMP_Text leafTxt;
}
