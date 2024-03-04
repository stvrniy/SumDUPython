# main.py

from functions import calculate_z

def calculate_sum_of_squares(N):
    return sum(i**2 for i in range(1, N+1))

if __name__ == "__main__":
    x = float(input("Введіть значення x: "))
    y = float(input("Введіть значення y: "))

    z_result = calculate_z(x, y)
    print(f"Значення z для x={x} та y={y}: {z_result}")

    N = int(input("Введіть значення N: "))
    sum_of_squares_result = calculate_sum_of_squares(N)
    print(f"Сума квадратів чисел від 1 до {N}: {sum_of_squares_result}")
