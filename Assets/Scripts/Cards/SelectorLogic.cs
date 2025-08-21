using UnityEngine;
using UnityEngine.EventSystems;

public class SelectorLogic : MonoBehaviour, IPointerClickHandler
{
    private Card card;
    private PrefabController prefabController;
    public void OnPointerClick(PointerEventData eventData)
    {
        prefabController = GetComponent<PrefabController>();
        card = prefabController.card;
        CardPlayLogic.CardManager.PlayCard(card);
    }
}

