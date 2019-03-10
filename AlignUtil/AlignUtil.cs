using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignUtil : MonoBehaviour
{
    public enum AlignType
    {
        LeftTop = 0,
        LeftBottom,
        RightTop,        
        RightBottom
    }

    public RectTransform target;
    public AlignType selfAlign;
    public AlignType targetAlign;
    private readonly Vector2[] aligns = new Vector2[] {
        new Vector2(0, 1), // left-top
        new Vector2(0, 0), // left-bottom
        new Vector2(1, 1), // right-top
        new Vector2(1, 0)  // right-bottom
    };

    public void SetAlign()
    {
        if (target == null) return;

        RectTransform trans = GetComponent<RectTransform>();

        #region save backup
        Transform backupParent = trans.parent;
        #endregion

        #region set align
        trans.SetParent(target);
        trans.pivot = aligns[(int)selfAlign];
        trans.anchorMin = aligns[(int)targetAlign];
        trans.anchorMax = aligns[(int)targetAlign];
        trans.anchoredPosition = new Vector2(0, 0);
        #endregion

        #region recover form backup
        trans.SetParent(backupParent);
        #endregion        
    }
}
