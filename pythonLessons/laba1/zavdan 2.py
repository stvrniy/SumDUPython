# Задані значення a та b
a = 5
b = 80

# Ініціалізація змінної для збереження суми квадратів чисел
sum_of_squares = 0

# Ітерація від a до b (включно)
for number in range(a, b + 1):
    # Додавання квадрату поточного числа до суми
    sum_of_squares += number ** 2

# Знайдення середнього арифметичного квадратів чисел
average = sum_of_squares / (b - a + 1)

# Виведення результату
print("Середнє арифметичне квадратів чисел від", a, "до", b, "дорівнює:", average)
