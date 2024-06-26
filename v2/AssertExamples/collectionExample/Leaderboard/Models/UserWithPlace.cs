namespace Leaderboard.Models;

public interface IUserWithPlace: IEquatable<IUserWithPlace>
{
    long UserId { get; }
    int Place { get; }
    
    
    public bool Equals(UserWithPlace? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return UserId == other.UserId && Place == other.Place;
        
        
    }
}

public class UserWithPlace: IUserWithPlace //, IComparable<UserWithPlace>
{
    public long UserId { get; }
    public int Place { get; }

    public UserWithPlace(long userId, int place)
    {
        UserId = userId;
        Place = place;
    }

    public bool Equals(IUserWithPlace? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return UserId == other.UserId && Place == other.Place;
    }

    // public int CompareTo(UserWithPlace? other)
    // {
    //     if (ReferenceEquals(this, other) && (UserId == other.UserId && Place == other.Place)) return 0;
    //     if (UserId < other.UserId)
    //     {
    //         return -1;
    //     }
    //     else 
    //         return 1;
    //
    //
    // }
}
