using System;
using  UI.Common;
using System.Collections.Generic;
using System.Linq;

using System.Data.SqlClient;
using System.Data.Entity.Validation;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using  Common;
using   DAL;
using   Entities;
using   Entities.DBEntities;
//using  Common.Logger;
//using   Entities.Enum;
using System.Data.Common;
//using   Entities.Security;
using System.Threading.Tasks;

namespace DAL
{
    class PRMDataService
    {
        public static TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");

        #region Stored Procedures

        private const String SP_DBO_SAVESTUDENT = "dbo.SaveStudent";
        private const String SP_DBO_DEACTIVATESTUDENT = "[dbo].[DeactivateStudent]";
        private const String SP_DBO_SEARCHSTUDENTS = "dbo.SearchStudents";

        private const String SP_DBO_GETAPPROVERHERIRACHYS = "dbo.GetApproverHerirachy";


        #endregion

        public PRMDataService()
        {
            Database.SetInitializer<PRMDataContext>(null);
        }

        /* ------------------------Save/Update Approaches-------------------------- */
        public DateTime ConvertfromUTC(DateTime d)
        {
            return d.ToTimeZoneTime(tzi);
        }
    }
}
