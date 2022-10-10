using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FinishView : MonoBehaviour
{
    public Action<FinishView> OnLevelObjectContact { get; set; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();
        if (levelObject != null)
            OnLevelObjectContact?.Invoke(this);
    }
}
