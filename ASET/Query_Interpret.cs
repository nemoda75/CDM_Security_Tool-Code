using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASET
{
    class Query_Interpret
    {
        public static bool Check_Fix_Required(string ID, int QUERY_NUMBER, string RESPONSE)
        {
            switch (ID)
            {
                case "CDMV-79061":
                    switch (QUERY_NUMBER)
                    {
                        case 0:
                            // EXEC sp_configure 'contained database authentication';
                            if (RESPONSE != "contained database authentication")
                            {
                                return true; // fix required
                            }
                            else
                            {
                                return false; // fix no required
                            }
                        case 1:
                            // SELECT CASE SERVERPROPERTY('IsIntegratedSecurityOnly') WHEN 1 THEN 'Windows Authentication' WHEN 0 THEN 'Windows and SQL Server Authentication' END as [Authentication Mode];
                            if (RESPONSE != "Windows and SQL Server Authentication")
                            {
                                return true; // fix required
                            }
                            else
                            {
                                return false; // fix no required
                            }
                        case 2:
                            // SELECT name FROM sys.database_principals WHERE type_desc = 'SQL_USER' AND authentication_type_desc = 'DATABASE';
                            if (RESPONSE == "(no data)")
                            {
                                return true; // fix required
                            }
                            else
                            {
                                return false; // fix no required
                            }
                    }
                    break;

                case "CDMV-79067":
                    if (RESPONSE != "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required
                    }

                case "CDMV-79069":
                    if (RESPONSE == "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required
                    }

                case "CDMV-79071":
                    switch (QUERY_NUMBER)
                    {
                        case 0:
                            // SELECT name as DatabaseName, SUSER_SNAME(owner_sid) AS DatabaseOwner, is_trustworthy_on FROM sys.databases;
                            if (string.IsNullOrEmpty(RESPONSE) || RESPONSE != "(no data)")
                            {
                                return true; // fix required
                            }
                            else
                            {
                                return false; // fix no required
                            }

                        case 1:
                            // DECLARE @databaseOwner AS nvarchar(50) SET @databaseOwner = 'sa';
                            return false; // fix no required
                    }
                    break;

                case "CDMV-79073":
                    // error 나므로 우선 pass
                    break;

                case "CDMV-79075":
                    switch (QUERY_NUMBER)
                    {
                        case 0:
                            // SELECT P.type_desc AS principal_type, P.name AS principal_name, O.type_desc, CASE class WHEN 0 THEN DB_NAME() WHEN 1 THEN OBJECT_SCHEMA_NAME(major_id) + '.' +  OBJECT_NAME(major_id) WHEN 3 THEN SCHEMA_NAME(major_id) ELSE class_desc + '(' + CAST(major_id AS nvarchar) + ')' END AS securable_name, DP.state_desc, DP.permission_name FROM sys.database_permissions DP JOIN sys.database_principals P ON DP.grantee_principal_id = P.principal_id LEFT OUTER JOIN sys.all_objects O ON O.object_id = DP.major_id AND O.type IN 'TR','TA','P','','RF','PC','IF','FN','TF','U') WHERE DP.type IN ('AL','ALTG') AND DP.class IN (0, 1, 53);
                            // error 나므로 우선 pass
                            break;

                        case 1:
                            // SELECT R.name AS role_name, M.type_desc AS principal_type, M.name AS principal_name FROM sys.database_principals R JOIN sys.database_role_members DRM ON R.principal_id = DRM.role_principal_id JOIN sys.database_principals M ON DRM.member_principal_id = M.principal_id WHERE R.name IN ('db ddladmin','db_owner') AND M.name != 'dbo';
                            if (RESPONSE == "(no data)")
                            {
                                return true; // fix required
                            }
                            else
                            {
                                return false; // fix no required
                            }
                    }
                    break;

                case "CDMV-79077":
                    if (RESPONSE != "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required
                    }

                case "CDMV-79079":
                    // error 나므로 우선 pass
                    break;

                case "CDMV-79081":
                    if (RESPONSE != "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required
                    }
                case "CDMV-79083":
                    return false; // fix no required

                case "CDMV-79085":
                    return false; // fix no required

                case "CDMV-79087":
                    if (RESPONSE != "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required

                    }
                case "CDMV-79091":
                    if (RESPONSE != "(no data)")
                    {
                        return true; // fix required
                    }
                    else
                    {
                        return false; // fix no required

                    }
            }
            return false;

        }
    }

}
