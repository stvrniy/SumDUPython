# Зчитування цілого числа N з клавіатури
N = int(input("Введіть ціле число N (1 < N < 9): "))

# Перевірка, чи введене число відповідає обмеженням
if 1 < N < 9:
    # Виведення рядків з числами
    for i in range(1, N + 1):
        for j in range(1, i + 1):
            print(j, end=" ")
        print()  # Перехід на новий рядок після кожного рядка чисел
else:
    print("Введене число не відповідає обмеженням.")

