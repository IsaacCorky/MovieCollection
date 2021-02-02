using System;
using System.Collections.Generic;

namespace MovieCollection.Models
{
    public static class Repository
    {
        private static List<NewMovie> responses = new List<NewMovie>();
        public static IEnumerable<NewMovie> Responses => responses;
        public static void AddResponse(NewMovie response)
        {
            responses.Add(response);
        }
    }
}
