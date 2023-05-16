using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCollect : MonoBehaviour
{
    public List<Sprite> collectibleSprites = new List<Sprite>();
    public Image collectedSpritesUI;
    private List<Sprite> collectedSprites = new List<Sprite>();

    private void OnDestroy()
    {
        CollectSprite();
    }

    private void CollectSprite()
    {
        if (collectibleSprites.Count > 0)
        {
            int randomIndex = Random.Range(0, collectibleSprites.Count);
            Sprite collectedSprite = collectibleSprites[randomIndex];

            collectedSprites.Add(collectedSprite);
            collectedSpritesUI.sprite = collectedSprite;
            collectedSpritesUI.gameObject.SetActive(true);

            collectibleSprites.RemoveAt(randomIndex);
        }
    }
}
