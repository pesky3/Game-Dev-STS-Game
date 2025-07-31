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
    
    public void IPointerEnterHandler(PointerEventData eventData)
    {

    }
}
