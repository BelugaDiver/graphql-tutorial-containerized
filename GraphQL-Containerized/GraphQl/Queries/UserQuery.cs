using GraphQL.Types;
using GraphQL_Containerized.Types;

namespace GraphQL_Containerized.Queries
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery()
        {
            Field<UserType>("user").Resolve(
                context => new User()
                );
        }
    }
}
