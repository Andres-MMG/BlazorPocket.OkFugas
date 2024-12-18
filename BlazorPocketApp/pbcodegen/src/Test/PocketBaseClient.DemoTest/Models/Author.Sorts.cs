
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm.Filters;

namespace PocketBaseClient.DemoTest.Models
{
    public partial class Author
    {
        public class Sorts : ItemBaseSorts
        {

            /// <summary>Makes a SortCommand to Order by the 'name' field</summary>
            public SortCommand Name => new SortCommand("name");

            /// <summary>Makes a SortCommand to Order by the 'email' field</summary>
            public SortCommand Email => new SortCommand("email");

            /// <summary>Makes a SortCommand to Order by the 'url' field</summary>
            public SortCommand Url => new SortCommand("url");

            /// <summary>Makes a SortCommand to Order by the 'profile' field</summary>
            public SortCommand Profile => new SortCommand("profile");


        }
    }
}
