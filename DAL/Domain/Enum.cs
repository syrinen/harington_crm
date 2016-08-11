using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public enum GenderType
    {
        Undef,
        Male,
        Female
    }

    public enum ExperienceLevel
    {
        Undef,
        Junior,
        Intermediate,
        Senior
    }

    public enum ExpertiseLevel
    {
        NotApplicable,
        Basic,
        Moderate,
        Good,        
        Excellent        
    }

    public enum EmploymentType
    {
        Undef,
        FullTime,
        PartTime
    }

    public enum ProfileType
    {
        Undef,
        Candidate,
        Collaborator
    }

    public enum InterviewState
    {
        Undef,
        Pass,
        Fail
    }

    public enum MissionState
    {
        Undef,
        Vacant,
        Occupied
    }

    public enum ContractType
    {
        Undef,
        CDI,
        CDD,
        Portage,
        Indep
    }

    public enum UserType
    {
        Profile,
        BI,
        HR
    }
}
