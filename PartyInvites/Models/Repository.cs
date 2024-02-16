namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestInvite> responses = new ();

        public static IEnumerable<GuestInvite> Response => responses; 

        public static void AddResponse(GuestInvite response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
