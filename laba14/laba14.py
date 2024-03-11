import matplotlib.pyplot as plt
import numpy as np

# Задаємо функцію Y(x)
def Y(x):
    return x**np.sin(10*x)

# Генеруємо значення x від 1 до 10
x_values = np.linspace(1, 10, 100)

# Обчислюємо значення Y для кожного x
y_values = Y(x_values)

# Побудова графіка
plt.plot(x_values, y_values, label='Y(x) = x^sin(10*x)', color='blue', linestyle='solid', linewidth=2)

# Додаємо позначення осей та заголовок графіка
plt.xlabel('X-axis')
plt.ylabel('Y-axis')
plt.title('Графік функції Y(x) = x^sin(10*x)')

# Додаємо легенду
plt.legend()

# Показуємо графік
plt.show()
