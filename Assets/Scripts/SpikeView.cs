using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SpikeView : MonoBehaviour
{
    public Action<SpikeView> OnLevelObjectContact { get; set; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();
        if (levelObject != null)
            OnLevelObjectContact?.Invoke(this);
    }
}
