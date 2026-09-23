using System;
using System.Collections.Generic;
using System.Text;

namespace RegretBook.Domain.Entities
{
    public interface ILikeable
    {
        bool CanBeLiked();

    }
}
// We know about enough about interfaces from TimCorey MasterCourse that it is more like a protocol of rules that a class inherit the interface must follow. It is a contract that defines a set of methods, properties, or events that a class must implement.
// Interface contain only the declation of methods, properties not there any implementation. 
// Thats why a class can't inherit from multiple parent classes but can implement multiple interfaces. 
// Its know as a diamond problem in OOP.where if a class inherits from multiple parent classes, it can lead to ambiguity and conflicts in method resolution as there can be multiple implementations of the same method in different parent classes.thus the object of the class will not know which method to call.whereas in interfaces, since they only define the contract and do not provide any implementation, there is no ambiguity or conflict in method resolution.