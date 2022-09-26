using System.Threading.Tasks;

class SportsСar : Car
{
    public SportsСar(float FuelConsumption, int FuelTankCapacity, int speed)
    {
        typeCar = TypeCar.SportCar;
        //type = 3;
        this.FuelConsumption = FuelConsumption;
        this.FuelTankCapacity = FuelTankCapacity;
        this.Speed = speed;
    }

    public override float GetFuelDistanceWithСargoOrPassengers()
        => GetFuelDistance();

    public override float GetFuelDistanceWithСargoOrPassengers(int fuelQuantity) 
        => GetFuelDistance(fuelQuantity);
    
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
        return GetTravelTime(distance);
    }

    public override float GetTravelTimeWithСargoOrPassengers(int distance, int fuelQuantity)
    {
        return GetTravelTime(distance, fuelQuantity);
    }
}