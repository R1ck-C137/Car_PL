using System.Runtime.InteropServices;
using System.Threading.Tasks;

class PassengerCar : Car
{

    public int PassengerSeats { get; set; }
    public int PassengerCount
    {
        get => passengerCount;

        set
        {
            if (value > PassengerSeats)
                throw new Exception("Кол-во пассажиров больше чем мест в автомобиле!");
            passengerCount = value;
        }
    }

    private int passengerCount;

    public PassengerCar(float fuelConsumption, int fuelTankCapacity, int speed, int passengerSeats)
    {
        typeCar = TypeCar.PassengerCar;
        //type = 1;
        this.FuelConsumption = fuelConsumption;
        this.FuelTankCapacity = fuelTankCapacity;
        this.Speed = speed;
        PassengerSeats = passengerSeats;
        //PassengerCount = passengerCount;
    }

    public override float GetFuelDistanceWithСargoOrPassengers()
        => (1 - 0.06f * passengerCount) * FuelTankCapacity / FuelConsumption;
        //=> FuelTankCapacity / (FuelConsumption * (1 + (0.06f * PassengerCount)));
        
    public override float GetFuelDistanceWithСargoOrPassengers(int fuelQuantity)
        => (1 - 0.06f * passengerCount) * fuelQuantity / FuelConsumption;
        //=> fuelQuantity / (FuelConsumption * (1 + (0.06f * PassengerCount)));

    public override float GetTravelTime(int distance)
    {
        if (GetFuelDistance() < distance)
            throw new Exception("Автомобилю не хватит топлива!");

        return distance / Speed;
    }

    public override float GetTravelTime(int distance, int fuelQuantity)
    {
        if (GetFuelDistance(fuelQuantity) < distance)
            throw new Exception("Автомобилю не хватит топлива!");

        return distance / Speed;
    }

    public override float GetTravelTimeWithСargoOrPassengers(int distance)
    {
        if (GetFuelDistanceWithСargoOrPassengers() < distance)
            throw new Exception("Автомобилю не хватит топлива!");

        return distance / Speed;
    }

    public override float GetTravelTimeWithСargoOrPassengers(int distance, int fuelQuantity)
    {
        if (GetFuelDistanceWithСargoOrPassengers(fuelQuantity) < distance)
            throw new Exception("Автомобилю не хватит топлива!");

        return distance / Speed;
    }
}   
