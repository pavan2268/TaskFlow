using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskFlow.Domain.Enum
{
    internal class TaskEnum
    {
        public enum Priority // Enum - A distinct type that consists of a set of named constants called the enumerator list. In this case, Priority is an enumeration that defines different levels of task priority.
        {
            Low = 1,
            Medium = 2,
            High = 3,
            Critical = 4
        }

        public enum TaskStaus // •	An enum (short for "enumeration") is a named list of related constant values. 2. Use it when a variable should only hold one value from a fixed set (e.g., priority levels or status).Enums make code clearer and less error - prone than using raw numbers or strings.
        {
            Todo=1,       //will let us know where the task is in the workflow, whether it's still to be done, in progress, under review, completed, or cancelled. This can help us manage and track the lifecycle of tasks effectively.
            InPrgress =2,
            InReview=3,
            Done= 4 ,
            Cancelled=5

        }

        public enum ProjectStatus // what state our project is in.
        {
            Active = 1,
            OnHold=2,
            Completed=3,
            Archived= 4
        } 
        public enum TenantPlan // subscription plan of the company using our app
        {
            Free = 1,
            Pro = 2,
            Enterprise = 3
        }






    }
}
