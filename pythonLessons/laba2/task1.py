import math

# Функція для обчислення z = cos(2x) + sin(2y)
def calculate_z():
    x = float(input("Введіть значення x: "))
    y = float(input("Введіть значення y: "))
    
    z = math.cos(2*x) + math.sin(2*y)
    
    print(f"Значення z для x={x} та y={y}: {z}")

# Функція для знаходження суми квадратів чисел від 1 до N
def calculate_sum_of_squares():
    N = int(input("Введіть значення N: "))
    
    # Знаходження суми квадратів чисел від 1 до N
    S = sum(i**2 for i in range(1, N+1))
    
    print(f"Сума квадратів чисел від 1 до {N}: {S}")

# Головна частина програми
if __name__ == "__main__":
    # Викликаємо функції користувача
    calculate_z()
    calculate_sum_of_squares()
