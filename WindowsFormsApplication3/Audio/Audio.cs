namespace FinancePermutator.Media
{
	public static class Audio
	{
		public static void PlayFoto()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "foto.wav"
			};
			player.Play();
		}

		public static void PlayCancel()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "chancel.wav"
			};
			player.Play();
		}

		public static void PlayStart()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "start.wav"
			};
			player.Play();
		}
	}
}