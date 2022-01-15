namespace FinancePermutator.Media
{
	public static class Audio
	{
		public static void playFoto()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "foto.wav"
			};
			player.Play();
		}

		public static void playCancel()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "chancel.wav"
			};
			player.Play();
		}

		public static void playStart()
		{
			System.Media.SoundPlayer player = new System.Media.SoundPlayer
			{
				SoundLocation = Configuration.path + "start.wav"
			};
			player.Play();
		}
	}
}
