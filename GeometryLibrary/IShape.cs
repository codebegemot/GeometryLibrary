namespace GeometryLibrary
{
    // здесь можно было бы создать базовый класс с не реализованным virtual методом, а при наследовании переопределять его
    public interface IShape
    {
        double CalculateArea();

        // если бы это был класс
        //public virtual double CalculateArea()
        //{
        //    throw new NotImplementedException("Area calculation is not implemented for this shape.");
        //}
    }
}