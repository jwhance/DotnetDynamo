namespace DotnetDynamo.Models
{
    public class CustomerRequest
    {
        public string GitHubUsername { get; init; } = default!;

        public string FullName { get; init; } = default!;

        public string Email { get; init; } = default!;

        public DateTime DateOfBirth { get; init; }

        public decimal Factor { get; set; }

        public Dictionary<string, Attributes> HerAttributes { get; set; } = [];

    }
}
