def find_min_positive_element(arr):
    # Ініціалізуємо мінімальний додатній елемент значенням, яке гарантовано буде більшим за будь-який елемент масиву
    min_positive = float('inf')

    # Проходимо по всіх елементах масиву
    for element in arr:
        # Перевіряємо, чи елемент додатний і чи менший за поточний мінімальний додатній
        if element > 0 and element < min_positive:
            min_positive = element

    return min_positive if min_positive != float('inf') else None  # Повертаємо мінімальний додатній елемент або None, якщо такого немає


# Введення розміру масиву
n = int(input("Введіть розмір масиву: "))

# Введення елементів масиву
array = [float(input(f"Введіть {i+1}-й елемент: ")) for i in range(n)]

# Знаходження та виведення мінімального додатнього елементу
result = find_min_positive_element(array)

if result is not None:
    print(f"Мінімальний додатній елемент: {result}")
else:
    print("Немає додатніх елементів у масиві.")
