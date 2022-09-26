using System.Threading.Tasks;

class Truck : Car
{
    public int LoadCapacity{ get; }

    public int CargoWeight
    {
        get => CargoWeight;
        
        set
        {
            if (CargoWeight > LoadCapacity)
                throw new Exception("Вес груза больше чем грузоподъёмность автомобиля!");
        }
    }

    public Truck(float fuelConsumption, int fuelTankCapacity, int speed, int loadCapacity)
    {
        typeCar = TypeCar.Truck;
        //type = 2;
        this.FuelConsumption = fuelConsumption;
        this.FuelTankCapacity = fuelTankCapacity;
        this.Speed = speed;
        LoadCapacity = loadCapacity;
        //CargoWeight = cargoWeight;
    }

    public override float GetFuelDistanceWithСargoOrPassengers()
        => (1 - 0.04f * (CargoWeight / 200)) * FuelTankCapacity / FuelConsumption;
    //=> FuelTankCapacity / (FuelConsumption * (1 + (0.04f * (CargoWeight / 200))));

    public override float GetFuelDistanceWithСargoOrPassengers(int fuelQuantity)
        => (1 - 0.04f * (CargoWeight / 200)) * fuelQuantity / FuelConsumption;
    //=> fuelQuantity / (FuelConsumption * (1 + (0.04f * (CargoWeight / 200))));

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