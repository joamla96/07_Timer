namespace _07_Timer {
	internal class Timer {
		private int seconds;
		public int Seconds {
			get { return this.seconds; }
			set { this.seconds = value; }
		}

		public Timer() {
			this.seconds = 0;
		}
	}
}