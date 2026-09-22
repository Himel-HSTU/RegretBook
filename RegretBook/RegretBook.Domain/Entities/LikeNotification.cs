using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikeByUserId { get; set; }

        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
            // this will go to constructor of Notification class and set the type to "Like"
            // then Notification class constructor will call BaseEntity constructor to set the Id,createdAt
            // Later it will initialize the _type field thn come here and LikeByUserId will be set to the passed value
        } 

        public void AddMessage(string message) 
        {
            // Assuming the base class has a protected property for Message
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"It will call the Base Entity Virtual Method: {baseRecord}, As well as the Extra added by override method LikeByUserId: {LikeByUserId} LikeNotification - Id: {Id}, CreatedAt: {CreatedAt}, ModifiedAt: {ModifiedAt}, ";
            
            //return $"Base Method Replaced!!!!! LikeNotification - Id: {Id}, CreatedAt: {CreatedAt}, ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedBy}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}, LikeByUserId: {LikeByUserId}";
        }
    }
}
