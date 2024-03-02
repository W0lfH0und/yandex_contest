using System;
using System.Linq;

var firstMatchInput = Console.ReadLine()!.Split(':');
var secondMatchInput = Console.ReadLine()!.Split(':');
bool isFirstTeamGuest = int.Parse(Console.ReadLine()!) == 1;

int firstTeamFirstMatchCount = int.Parse(firstMatchInput.First());
int secondTeamFirstMatchCount = int.Parse(firstMatchInput.Last());

int firstTeamSecondMatchCount = int.Parse(secondMatchInput.First());
int secondTeamSecondMatchCount = int.Parse(secondMatchInput.Last());

int firstTeamTotal = firstTeamFirstMatchCount + firstTeamSecondMatchCount;
int secondTeamTotal = secondTeamFirstMatchCount + secondTeamSecondMatchCount;

int firstTeamGuestGoals = isFirstTeamGuest ? firstTeamSecondMatchCount : firstTeamFirstMatchCount;
int secondTeamGuestGoals = isFirstTeamGuest ? secondTeamFirstMatchCount : secondTeamSecondMatchCount;
int secondTeamLeadingGoals = secondTeamTotal - firstTeamTotal;

int goalsToFirstTeamWin = secondTeamLeadingGoals < 0 
    ? 0 
    : secondTeamLeadingGoals == 0
        ? firstTeamGuestGoals > secondTeamGuestGoals ? 0 : 1
        : secondTeamLeadingGoals + (isFirstTeamGuest && firstTeamGuestGoals + secondTeamLeadingGoals > secondTeamGuestGoals
                                    || !isFirstTeamGuest && firstTeamGuestGoals > secondTeamGuestGoals ? 0 : 1);

Console.WriteLine(goalsToFirstTeamWin);
Console.ReadLine();