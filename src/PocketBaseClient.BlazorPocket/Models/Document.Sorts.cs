
// This file was generated automatically for the PocketBase Application Acme (http://localhost:8090)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm.Filters;

namespace PocketBaseClient.BlazorPocket.Models
{
    public partial class Document
    {
        public class Sorts : ItemBaseSorts
        {

            /// <summary>Makes a SortCommand to Order by the 'name' field</summary>
            public SortCommand Name => new SortCommand("name");

            /// <summary>Makes a SortCommand to Order by the 'file' field</summary>
            public SortCommand File => new SortCommand("file");

            /// <summary>Makes a SortCommand to Order by the 'owner' field</summary>
            public SortCommand Owner => new SortCommand("owner");


        }
    }
}
