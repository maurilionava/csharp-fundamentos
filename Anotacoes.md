Diferenças entre ValueType e ReferenceType
ValueType armazena um valor diretamente na memória
ReferenceType armazena uma referência a um espaço da memória que contém os dados

Os processamentos de boxing e unboxing degradam a performance

Boxing: conversão do ValueType para ReferenceType
int num = 2;
Object obj = num; // boxing

Unboxing: conversão do ReferenceType para ValueType
int num = 2;
Object obj = num; // boxing
int num2 = (int) obj; // unboxing

Todo valor passado para uma ArrayList é convertido para o tipo Object
Na coleção de List não é realizado o boxing já que é definido o tipo que será armazenado

**REVIEW**
- Memórias Heap vs memória Stack
- Tipo de valor vs tipo de referência
- Propriedades vs campos
- Tipo anônimo
- Classes parciais: funciona para classes, interfaces, structs e métodos
- Os pilares da POO: abstração, encapsulamento, herança, polimorfismo
- Paradigmas de programação
- Downcasting e upcasting
- Delegates
- Cast vs convert