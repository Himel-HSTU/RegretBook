using RegretBook.Domain.Entities;



//var Likenotfication = new LikeNotification(Guid.NewGuid());
//Console.WriteLine(Likenotfication.DescribeRecord());

//Console.WriteLine(Likenotfication.GetMessage());

//Upcasting - Child Class ke Parent class diye store kora jay.

var notifications = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new SystemNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid())
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}