namespace ChatGpt.Models
{
    public class ChatGPTInputModel
    {
        public ChatGPTInputModel(string prompt)
        {
            this.prompt = $"Correct this english phrase: {prompt}";
            max_tokens = 100;
            temperature = 0.2m;
            model = "text-davinci-003";
        }

        public string model { get; set; }
        public string prompt { get; set; }
        public int max_tokens { get; set; }
        public decimal temperature { get; set; }

    }
}
