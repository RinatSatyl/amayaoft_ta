using UnityEngine;
using UnityEngine.UI;

public class GridSize : MonoBehaviour
{
    [SerializeField]
    Image grid;

    [SerializeField]
    int fieldMinimalHorizontalSize = 3;

    int gridAmount = 0;
    float cardSize = 0;
    float horizontalSize = 0;
    float verticalSize = 0;

    public void ResizeGrid()
    {
        horizontalSize = (grid.transform.childCount / gridAmount) * cardSize;
        verticalSize = gridAmount * cardSize;
        grid.rectTransform.sizeDelta = new Vector2(horizontalSize, verticalSize);
    }

    public void CalculateGridSize()
    {
        if (grid.transform.childCount % fieldMinimalHorizontalSize == 0)
        {
            gridAmount = grid.transform.childCount / fieldMinimalHorizontalSize;
        }
        RectTransform rect = (RectTransform)grid.transform.GetChild(0).transform;
        cardSize = rect.rect.width;
    }
}
