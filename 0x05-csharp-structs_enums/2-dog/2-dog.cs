using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string myName, float myAge, string myOwner, Rating myRating)
    {
        name = myName;
        age = myAge;
        owner = myOwner;
        rating = myRating;
    }
}
