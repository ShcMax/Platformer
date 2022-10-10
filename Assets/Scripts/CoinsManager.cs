using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class CoinsManager : IDisposable
{
    private SpriteAnimator _spriteAnimator;
    private List<CoinView> _coinViews;

    public CoinsManager(List<CoinView> coinViews)
    {
        _coinViews = coinViews;

        foreach(var coinView in _coinViews)
        {
            coinView.OnLevelObjectContact += OnLevelObjectContact;
        }
    }

    private void OnLevelObjectContact(CoinView contactView)
    {
        if (_coinViews.Contains(contactView))
            Object.Destroy(contactView.gameObject);
        Debug.Log("Вы подобрали монету");
    }

    public void Dispose()
    {
        foreach (var coinView in _coinViews)
            coinView.OnLevelObjectContact -= OnLevelObjectContact;
    }
}
