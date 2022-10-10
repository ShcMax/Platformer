using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

public class FinishManager: IDisposable
{
    private List <FinishView> _finishViews;

    public FinishManager(List<FinishView> finishViews)
    {
        _finishViews = finishViews;
        
        foreach(var finishView in _finishViews)
        {
            finishView.OnLevelObjectContact += OnLevelObjectContact;
        }
    }

    private void OnLevelObjectContact(FinishView finishView)
    {
        if (_finishViews.Contains(finishView))
            Object.Destroy(finishView.gameObject);
            Debug.Log("Вы прошли уровень");
    }

    public void Dispose()
    {
        foreach(var finishView in _finishViews)
        {
            finishView.OnLevelObjectContact -= OnLevelObjectContact;
        }
    }
}
