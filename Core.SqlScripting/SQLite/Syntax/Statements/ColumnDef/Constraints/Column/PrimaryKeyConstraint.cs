﻿using Core.SqlScripting.Common.Syntax;
using Core.SqlScripting.SQLite.Syntax.Enums;

namespace Core.SqlScripting.SQLite.Syntax.Statements.ColumnDef.Constraints.Column
{
    public class PrimaryKeyConstraint : AbstractSqlColumnConstraint
    {
        public SortOrder      Order          { get; set; } = SortOrder.Default;
        public bool           Autoincrement  { get; set; } = false;
        public SqlConflictClause ConflictClause { get; set; } = SqlConflictClause.Default;
    }
}