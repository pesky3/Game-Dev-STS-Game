using UnityEngine;
using UnityEngine.EventSystems;

public class SelectorLogic : MonoBehaviour
{
    public void SelectEnemy(Enemy enemy)
    {
        CardPlayLogic.CardManager.SelectedEnemy = enemy;
    }
    void Update()
    {
        
    }
    
    public void OnMouseOver()
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CardPlayLogic.CardManager.SelectedEnemy = null;
    }

    public void OnMouseDown()
    {
        if (CardPlayLogic.CardManager.SelectedEnemy != null)
        {
            //CardPlayLogic.PlayCard();
        }
    }
}

