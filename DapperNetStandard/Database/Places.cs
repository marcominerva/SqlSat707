using Dapper;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperNetStandard
{
    public class Places
    {
        private const string language = "";
        private const string projectId = "";

        private readonly string connectionString;

        public Places(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<Place>> SearchAsync(string query)
        {
            var sql = @"SELECT pl.Name, pl.Description, p.ImageUrl
                        FROM PlaceLanguages pl
                        INNER JOIN Places p ON pl.PlaceId = p.PlaceId
                        WHERE pl.LanguageCode = @language AND p.ProjectId = @projectId
                        AND (pl.Name LIKE @query OR pl.Description LIKE @query)
                        ORDER BY pl.[Name]";

            using (var conn = new SqlConnection(connectionString))
            {
                var places = await conn.QueryAsync<Place>(sql, new { language = language, projectId = projectId, query = $"%{query}%" });
                return places;
            }
        }
    }
}
