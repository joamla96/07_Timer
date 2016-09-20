using System;

namespace _07_Timer {
	internal class Timer {
		private int seconds = 0;
		private int minutes = 0;
		private int hours = 0;
		public int Seconds {
			get { return this.seconds; }
			set { this.seconds = value; }
		}

		public override string ToString() {
			while(this.seconds >= 60) {
				this.seconds -= 60;
				this.minutes++;

				if(minutes == 60) {
					this.minutes = 0;
					this.hours++;
				}
			}

			return this.Padded(this.seconds) 
				+ this.Padded(this.minutes) 
				+ this.Padded(this.hours);
		}

		public string Padded(int Input) {
			return String.Format("{0:00}", Input);
		}
	}
}