using GraphQL.Types;
using GraphQL_Containerized.Queries;
using System.Web.Http.Dependencies;

namespace GraphQL_Containerized.GraphQl.Schemas
{
    public class UserSchema: Schema
    {
        public UserSchema()
        {
            Query = new UserQuery();
        }
    }
}
