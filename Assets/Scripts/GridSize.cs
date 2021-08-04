using UnityEngine;
using UnityEngine.UI;

public class GridSize : MonoBehaviour
{
    [SerializeField]
    Image grid;
    [SerializeField]
    GridLayoutGroup gridComponent;

    float cardSize = 0;
    float rows = 3;
    float collums = 1;

    const int extraPadding = 8;
    const int optimalGridConfig = 3;

    public void ResizeGrid()
    {
        grid.rectTransform.sizeDelta = new Vector2((rows * cardSize) + extraPadding, (collums * cardSize) + extraPadding);
    }

    public void CalculateGridSize()
    {
        float sqrRT = Mathf.Sqrt(grid.transform.childCount);
        if (Mathf.CeilToInt(sqrRT) % optimalGridConfig == 0)
        {
            rows = Mathf.CeilToInt(sqrRT);
            collums = Mathf.CeilToInt(sqrRT);
        }
        cardSize = gridComponent.cellSize.x;
    }
}
