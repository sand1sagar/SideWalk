using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace Sidewalk.Logic.Database
{
    public static class MultipleResultSet
    {
        public static MultipleResultSetWrapper MultipleResults(this DbContext db, string storedProcedure)
        {
            return new MultipleResultSetWrapper(db, storedProcedure);
        }

        public class MultipleResultSetWrapper
        {
            private readonly DbContext _db;
            private readonly string _storedProcedure;
            public List<Func<IObjectContextAdapter, DbDataReader, IEnumerable>> _resultSets;

            public MultipleResultSetWrapper(DbContext db, string storedProcedure)
            {
                _db = db;
                _storedProcedure = storedProcedure;
                _resultSets = new List<Func<IObjectContextAdapter, DbDataReader, IEnumerable>>();
            }

            public MultipleResultSetWrapper With<TResult>()
            {
                _resultSets.Add((adapter, reader) => adapter
                    .ObjectContext
                    .Translate<TResult>(reader)
                    .ToList());

                return this;
            }

            public List<IEnumerable> Execute(params object[] parameters)
            {
                var results = new List<IEnumerable>();

                using (var connection = new SqlConnection(_db.Database.Connection.ConnectionString))
                {
                    using (var cmd = new SqlCommand(_storedProcedure, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddRange(parameters);
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var reader = cmd.ExecuteReader())
                        {
                            var adapter = ((IObjectContextAdapter)_db);
                            foreach (var resultSet in _resultSets)
                            {
                                results.Add(resultSet(adapter, reader));
                                reader.NextResult();
                            }
                        }

                        return results;
                    }
                }
            }
        }
    }
}
