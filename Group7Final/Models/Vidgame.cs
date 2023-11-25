namespace Group7Final.Models
{
	public class Vidgame
	{
		public int Id { get; set; }
		public string TeamMember { get; set; }
		public string GameName { get; set; }
		public string GameGenre { get; set; }
		public string GameStudio { get; set; }

		public string GetText()
		{
			return $"{Id} \t {TeamMember} \t {GameName} \t {GameGenre} \t {GameStudio}";
		}
	}
}
