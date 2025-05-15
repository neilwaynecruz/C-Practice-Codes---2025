// I dont use top level here so no namespace is needed


// getters and setters = add security to fields by encapsulating them
//                       they are accessors found within a proerties


// proterties = a member that provides a flexible mechanism to read, write or compute the value of a private field
// get accessor = returns the property value
// set accessor = assigns a new value to the property
// value keyword = the value assigned to the property in the set accessor


Car car = new Car(60);

car.Speed = 120; // This will set the speed to 100 due to the setter logic
Console.WriteLine(car.Speed); // Output: 100 because the setter limits the speed to a maximum of 100


class Car
{
    private int speed = 0;

    public Car(int speed)
    {
        Speed = speed;
    }

    public int Speed
    {
        get { return speed; }

        set
        {
           if (value < 0)
           {
                speed = 0;
           }
           else if (value > 500)
           {
                speed = 500;
           }
           else
           {
                speed = value;
            }
        }
    }
}