using System;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    public Action<CoinView> OnLevelObjectContact { get; set; }
    public SpriteRenderer SpriteRenderer => _spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();

        if (levelObject != null)
            OnLevelObjectContact?.Invoke(this);
    }
}
