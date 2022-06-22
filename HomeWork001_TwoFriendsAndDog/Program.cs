int FirstFriendSpeed = 5;
int SecondFriendSpeed = 7;
int DogSpeed = 15;
int DistanceBetweenFriends = 1000;
int FinalDistance = 100;
int FriendsCounter = 0;
int RunsCounter = 0;

while(DistanceBetweenFriends > FinalDistance)
{
    if (FriendsCounter == 0)
    {
        DistanceBetweenFriends = DistanceBetweenFriends - ((FirstFriendSpeed+SecondFriendSpeed) * (DistanceBetweenFriends/(FirstFriendSpeed+DogSpeed)));
        RunsCounter ++;
        FriendsCounter = 1;
    }
    if (FriendsCounter == 1)
    {
        DistanceBetweenFriends = DistanceBetweenFriends - ((FirstFriendSpeed+SecondFriendSpeed) * (DistanceBetweenFriends/(SecondFriendSpeed+DogSpeed)));
        RunsCounter ++;
        FriendsCounter = 0;
    }
}
Console.WriteLine(RunsCounter);
