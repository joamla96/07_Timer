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

				if(minutes >= 60) {
					this.minutes -= 60;
					this.hours++;
				}
			}

			return String.Format("{0:00}:{1:00}:{2:00}", 
					this.hours, this.minutes, this.seconds);
		}
	}
}