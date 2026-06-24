using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private NumberCard cardPrefab;
    [SerializeField] private Transform cardContainer;

    private readonly List<NumberCard> activeCards = new List<NumberCard>();

    void Start()
    {
        SpawnStartingCards();
    }

    public void SpawnStartingCards()
    {
        for (int i = 0; i < 4; ++i)
        {
            int value = i+1;
            NumberCard card = Instantiate(cardPrefab, cardContainer);

            card.SetValue(value);
            activeCards.Add(card);
        }
    }
}
