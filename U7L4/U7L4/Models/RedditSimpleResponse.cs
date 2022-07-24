namespace U7L4.Models
{
    public class RedditSimpleResponse
    {
        public string kind { get; set; }
        public RedditSimpleResponse_Data data { get; set; }
    }

    public class RedditSimpleResponse_Data
    {
        public string after { get; set; }
        public RedditSimpleResponse_Data_Child[] children { get; set; }
    }

    public class RedditSimpleResponse_Data_Child
    {
        public string kind { get; set; }
        public RedditSimpleResponse_Data_Child_Data data { get; set; }
    }

    public class RedditSimpleResponse_Data_Child_Data
    {
        public string title { get; set; }
        public RedditSimpleResponse_Data_Child_Data_LinkFlairRichText[] link_flair_richtext { get; set; }
    }

    public class RedditSimpleResponse_Data_Child_Data_LinkFlairRichText
    {
        public string a { get; set; }
        public string e { get; set; }
        public string u { get; set; }
    }
}
