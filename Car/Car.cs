using System.Threading.Tasks;

abstract class Car
{
    protected enum TypeCar
    {
        PassengerCar = 0,
        SportCar,
        Truck
    }

    protected TypeCar typeCar;
    //protected byte type; 
    public float FuelConsumption { get; set; }
    public int FuelTankCapacity { get; set; }
    public int Speed { get; set; }

    /// <summary>
    /// Возвращает запас хода на полном баке, без учёта пассажиров или груза.
    /// </summary>
    public float GetFuelDistance() 
        => FuelTankCapacity / FuelConsumption;
    /// <summary>
    /// Возвращает запас хода на заданном количестве топлива, без учёта пассажиров или груза.
    /// </summary>
    public float GetFuelDistance(int fuelQuantity)
        => (float)(fuelQuantity / FuelConsumption);
    /// <summary>
    /// Возвращает запас хода на полном баке с учётом пассажиров или груза.
    /// </summary>
    public abstract float GetFuelDistanceWithСargoOrPassengers();
    /// <summary>
    /// Возвращает запас хода с учётом пассажиров или груза, на заданном количестве топлива.
    /// </summary>
    public abstract float GetFuelDistanceWithСargoOrPassengers(int fuelQuantity);
    /// <summary>
    /// Возвращает время (в часах) за которое автомобиль проедет заданное расстояние,
    /// без учёта груза, на полном баке.
    /// </summary>
    public abstract float GetTravelTime(int distance);
    /// <summary>
    /// Возвращает время (в часах) за которое автомобиль проедет заданное расстояние, 
    /// без учёта груза, на заданном количестве топлива.
    /// </summary>
    public abstract float GetTravelTime(int distance, int fuelQuantity);
    /// <summary>
    /// Возвращает время (в часах) за которое автомобиль проедет заданное расстояние, 
    /// с учётом груза, на полном баке.
    /// </summary>
    public abstract float GetTravelTimeWithСargoOrPassengers(int distance);
    /// <summary>
    /// Возвращает время (в часах) за которое автомобиль проедет заданное расстояние,
    /// с учётом груза, на заданном количестве топлива.
    /// </summary>
    public abstract float GetTravelTimeWithСargoOrPassengers(int distance, int fuelQuantity);
}