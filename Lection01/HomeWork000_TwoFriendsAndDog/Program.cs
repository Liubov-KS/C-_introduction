float FirstFriendSpeed = 5;
float SecondFriendSpeed = 7;
float DogSpeed = 15;
float DistanceBetweenFriends = 1000;
int FinalDistance = 5;
int FriendsCounter = 0;
int RunsCounter = 0;

while(DistanceBetweenFriends > FinalDistance)
{
    if (FriendsCounter == 0)
    {
        DistanceBetweenFriends -= ((FirstFriendSpeed+SecondFriendSpeed) * (DistanceBetweenFriends/(FirstFriendSpeed+DogSpeed)));
        RunsCounter ++;
        if (DistanceBetweenFriends <= FinalDistance) break; // если после очередной пробежки от 1 друга к 2 дистанция уже меньше минимально, не надо бежать еще раз
        FriendsCounter = 1;
    }
    if (FriendsCounter == 1)
    {
        DistanceBetweenFriends -= ((FirstFriendSpeed+SecondFriendSpeed) * (DistanceBetweenFriends/(SecondFriendSpeed+DogSpeed)));
        RunsCounter ++;
        if (DistanceBetweenFriends <= FinalDistance) break; // мы не знаем, с какого друга может начинатся игра и быть может они уже в упор друг другу
        FriendsCounter = 0;
    }
}
Console.WriteLine(RunsCounter);
