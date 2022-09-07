using GraphQL.Types;
using GraphQL_Containerized.Queries;

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
