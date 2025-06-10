public class TiposAnulaveis
{
    public void TestarTiposAnulaveis()
    {
        Nullable<int> nullableInt = null;
        Nullable<double> nullableDouble = null;

        // null conditional operator *?*
        int? nullableInt2 = null;
        double? nullableDouble2 = null;

        int notNullableInt = 0;
        double notNullableDouble = 0.0d;

        // um nullable type é diferente do tipo padrão ou seja int? != int
        // int notNullableInt = nullableInt; 
        // opção: utilizar operador de coalescencia nula
        notNullableInt = nullableInt ?? 0;

        System.Console.WriteLine(nullableInt == notNullableInt);
        System.Console.WriteLine(notNullableDouble != nullableDouble);

        //propriedades HasValue Value do NullableType
        if (nullableInt.HasValue)
            System.Console.WriteLine(nullableInt.Value);
    }
}