using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Resume_Builder.Models
{
    public class ResumeDbInitializer : DropCreateDatabaseIfModelChanges<Resume_Builder.Models.ResumeDb>
    {
        protected override void Seed(Resume_Builder.Models.ResumeDb context)
        {
            //string query = "USE [ResumeDb] SELECT dbfile.name AS DatabaseFileName," +
            //    " sysFG.name AS FileGroupName," +
            //    " dbfile.physical_name AS DatabaseFilePath" +
            //    " FROM" +
            //    " sys.database_files AS dbfile" +
            //    " INNER JOIN" +
            //    " sys.filegroups AS sysFG" +
            //    " ON dbfile.data_space_id = sysFG.data_space_id";


            //string query = "USE [ResumeDb] SELECT sysFG.name +'||'+ dbfile.name +'||'+ dbfile.physical_name" +
            //    " FROM" +
            //    " sys.database_files AS dbfile" +
            //    " INNER JOIN" +
            //    " sys.filegroups AS sysFG" +
            //    " ON dbfile.data_space_id = sysFG.data_space_id";

            //var queryResult = context.Database.SqlQuery<string>(query).ToList();

            //if (queryResult.Count(q => q.StartsWith("FileStreamGroup")) == 0)
            //{
            //    string filePath = queryResult.Where(q => q.StartsWith("PRIMARY")).FirstOrDefault();
            //    filePath = filePath.Substring(filePath.LastIndexOf("||") + 2);
            //    filePath = filePath.Substring(0, filePath.LastIndexOf("\\"));
            //    context.Database.ExecuteSqlCommand("ALTER DATABASE ResumeDb " +
            //    "ADD FILEGROUP FileStreamGroup " +
            //    "CONTAINS FILESTREAM ALTER DATABASE ResumeDb " +
            //        "ADD FILE (NAME='ResumeDbFS', FILENAME=N'" + filePath + "\\ResumeDbFS2') " +
            //        "TO FILEGROUP FileStreamGroup ");
            //}

            //context.Database.ExecuteSqlCommand("ALTER TABLE Resumes " +
            //    "ADD [UniqueIdentity] uniqueidentifier NOT NULL ROWGUIDCOL UNIQUE DEFAULT NEWSEQUENTIALID()" +
            //    " EXEC sp_RENAME '[Resumes].[Content]', 'ContentTemp' , 'COLUMN' " +
            //    "ALTER TABLE  [dbo].[Resumes] " +
            //    "ADD [Content] varbinary(max) FILESTREAM NULL " +
            //    "ALTER TABLE  [dbo].[Resumes] " +
            //    "DROP COLUMN ContentTemp");


            //context.Database.ExecuteSqlCommand("ALTER TABLE Resumes " +
            //    "ADD [UniqueIdentity] uniqueidentifier NOT NULL ROWGUIDCOL UNIQUE DEFAULT NEWSEQUENTIALID()");

            //context.Database.ExecuteSqlCommand("EXEC sp_RENAME '[Resumes].[Content]', 'ContentTemp' , 'COLUMN'");

            //context.Database.ExecuteSqlCommand("ALTER TABLE  [dbo].[Resumes] " +
            //    "ADD [Content] varbinary(max) FILESTREAM NULL");

            //context.Database.ExecuteSqlCommand("UPDATE  [dbo].[Resumes] " +
            //    "SET [Content] = [ContentTemp]");

            //context.Database.ExecuteSqlCommand("ALTER TABLE  [dbo].[Resumes] " +
            //    "DROP COLUMN ContentTemp");
        }
    }
}