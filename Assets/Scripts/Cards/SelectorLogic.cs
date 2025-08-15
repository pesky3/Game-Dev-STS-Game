using UnityEngine;
using UnityEngine.EventSystems;

public class SelectorLogic : MonoBehaviour
{
    public void SelectEnemy(Enemy enemy)
    {
        CardPlayLogic.CardManager.SelectedEnemy = enemy;
    }
    


    public void OnPointerExit(PointerEventData eventData)
    {
        CardPlayLogic.CardManager.SelectedEnemy = null;
    }

    public void OnMouseDown()
    {
        
    }
}

