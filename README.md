## Итоговая проверочная работа
**Задача:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
### Описание решения
1. У пользователя запрашивается размер изначального массива
2. Пользователь заполняет массив.
3. Далее используется метод, в котором из первого массива остаются только элементы, которые меньше или равны 3 символам.
    1. Создаётся новый массив, идентичный по размеру первому.
    2. Для отслеживания количества элементов в новом массиве создаётся переменная count.
    3. Через цикл for проверяем все элементы на соответствие нужной длине. Если элемент подходит, он записывается в новый массив с индексом count, а переменная увеличивается на 1. 
    4. Новый массив подправляется по размеру с помощью переменной count.
4. Выводится новый массив из нужных элментов. Если таких элементов нет, то выводится сообщение, что массив пуст.


### Блок-схема алгоритма содержится в файле block_diagram.jpg
### Программа находится в файле Program.cs