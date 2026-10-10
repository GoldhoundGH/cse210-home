public class Entry
{
    public string _response;
    public string _date;
    public string _prompt;

    
    public string GetPrompt()
    {
        List<string> _promptList = new List<string>();
        _promptList.Add("Who did you spend the most time with today?");
        _promptList.Add("What did you accomplish today?");
        _promptList.Add("What happened today worth remembering?");
        _promptList.Add("What is on your mind right now?");
        _promptList.Add("What are you looking forward to tomorrow?");
        _promptList.Add("What do you hope to acheive this month?");

        Random randomNum = new Random();
        int selectPrompt = randomNum.Next(0,_promptList.Count());
        
        return _promptList[selectPrompt];
    }
}