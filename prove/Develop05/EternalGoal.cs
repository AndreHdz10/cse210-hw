public class EternalGoal : Goal
{

    /// <summary>
    /// EternalGoal constructor asking all parameters
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <param name="completionCount">Quantity of times that goal was accomplished</param>
    /// <returns>EternalGoal object</returns>
    public EternalGoal(string name, string description, int rewardPoints, int completionCount)
    {
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = completionCount;
    }

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _rewardPoints = 0;
        _completionCount = 0;
    }

    public override void RecordEvent()
    {
        _completionCount++;
        Console.WriteLine($"Congratulations! You have earned {_rewardPoints} points!");
    }

    public override void AskInformation()
    {
        Console.WriteLine("\nSimple Goal: It is a goal which is repeated over the time without contraints\n");

        Console.Write($"{questionGoalName} ");
        _name = Console.ReadLine();

        Console.Write($"\n{questionGoalDescription} ");
        _description = Console.ReadLine();

        Console.Write($"\n{questionGoalPoints} ");
        _rewardPoints = int.Parse(Console.ReadLine());
    }

    public override string ToText(Boolean isShort)
    {
        string objectFormatted = "";

        if (isShort)
        {
            objectFormatted = $"[ ] {_name} ({_description})";
        }
        else
        {
            objectFormatted = $"EternalGoal,{_name},{_description},{_rewardPoints},{_completionCount}";
        }

        return objectFormatted;
    }
}