using System;
using System.Threading.Tasks;

namespace fotobuch2.Core.Services
{
    public class InitializationService : IInitializationService
    {
		public const string Json = "{\n    \"types\": [{\n            \"title\": \"KLeines Buch\",\n            \"id\": 1,\n            \"price\": 0.0,\n            \"imageName\": \"fotobuch.png\"\n        },\n        {\n            \"title\": \"mittelkleines Buch\",\n            \"id\": 2,\n            \"price\": 15.0,\n            \"imageName\": \"fotobuch.png\"\n        },\n        {\n            \"title\": \"mittleres Buch\",\n            \"id\": 3,\n            \"price\": 25.0,\n            \"imageName\": \"fotobuch.png\"\n        },\n        {\n            \"title\": \"mittelgroßes Buch\",\n            \"id\": 4,\n            \"price\": 35.0,\n            \"imageName\": \"fotobuch.png\"\n        },\n        {\n            \"title\": \"großes Buch\",\n            \"id\": 5,\n            \"price\": 45.0,\n            \"imageName\": \"fotobuch.png\"\n        }\n    ]\n}";

		private readonly IStorageService _storageService;

        public InitializationService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task Initialize()
        {
            await _storageService.CreateTextFile(Json, GlobalConstants.ProductTypes);
        }
    }
}
