using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuestStory : IQuestStory
{
    private readonly List<IQuest> _questsCollection;

    public bool IsDone => _questsCollection.All(value => value.IsCompleted);
    
    public QuestStory(List<IQuest> questsCollection)
    {
        _questsCollection = questsCollection;
        Subscribe();
        ResetQuest(0);
    }

    private void Subscribe()
    {
        foreach (var quest in _questsCollection) 
            quest.Completed += OnQuestCompleted;
    }
  
    private void Unsubscribe()
    {
        foreach (var quest in _questsCollection) 
            quest.Completed -= OnQuestCompleted;
    }

    private void OnQuestCompleted(IQuest quest)
    {
        var index = _questsCollection.IndexOf(quest);
        
        if (IsDone)
            Debug.Log("Story done!");
        else
            ResetQuest(++index);
    }

    private void ResetQuest(int index)
    {
        if (index < 0 || index >= _questsCollection.Count) 
            return;
        
        var nextQuest = _questsCollection[index];
        
        if (nextQuest.IsCompleted) 
            OnQuestCompleted(nextQuest);
        else 
            _questsCollection[index].Reset();
    }  
  
    public void Dispose()
    {
        Unsubscribe();
    }
}
