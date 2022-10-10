using UnityEngine;
using System;
using System.Collections.Generic;
using Object = UnityEngine.Object;


public class SpikesManager : IDisposable
{
    private List<SpikeView> _spikeViews;

    public SpikesManager(List<SpikeView> spikeViews)
    {
        _spikeViews = spikeViews;

        foreach(var spikeView in _spikeViews)
        {
            spikeView.OnLevelObjectContact += OnLevelObjectContact;
        }
    }

    private void OnLevelObjectContact(SpikeView contactView)
    {
        if (_spikeViews.Contains(contactView))
            Debug.Log("Вы получили урон");
    }

    public void Dispose()
    {
        foreach (var spikeView in _spikeViews)
        {
            spikeView.OnLevelObjectContact -= OnLevelObjectContact;
        }
    }
}
