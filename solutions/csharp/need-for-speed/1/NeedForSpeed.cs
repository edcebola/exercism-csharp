class RemoteControlCar(int speed, int batteryDrain)
{
	private int battery = 100;
	private int distanceDriven;

	public bool BatteryDrained()
	{
		if (battery < batteryDrain) return true;
		else return false;
	}

	public int DistanceDriven()
	{
		return distanceDriven;
	}

	public void Drive()
	{
		if (!BatteryDrained())
		{
			distanceDriven += speed;
			battery -= batteryDrain;
		}
	}

	public static RemoteControlCar Nitro(int speed = 50, int batteryDrain = 4) => new(speed, batteryDrain);
}

class RaceTrack(int distance)
{
	public bool TryFinishTrack(RemoteControlCar car)
	{
		while (car.DistanceDriven() != distance)
		{
			if (car.BatteryDrained()) return false;
			car.Drive();
		}
		return true;
	}
}
