namespace BandsMvc.Models
{
	public class DataService
	{
		List<Band> bands = new List<Band>()
		{
			new Band { Id = 312, Name = "Zutomayo", Description = "JP Rock"},
			new Band { Id = 543, Name = "Musical Youth", Description = "Reggae"},
			new Band { Id = 33, Name = "N.W.A", Description = "Hip Hop"},
		};

		public Band GetBandById(int id)
		{
			return bands
				.First(x => x.Id == id);
		}

		public Band[] GetAllBands()
		{
			return bands
				.OrderBy(x => x.Name)
				.ToArray();
		}

	}
}
