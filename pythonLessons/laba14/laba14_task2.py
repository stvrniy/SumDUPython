import pandas as pd
import matplotlib.pyplot as plt

# Завантажте ваш .csv файл або скористайтеся зразком
# data = pd.read_csv('шлях_до_вашого_файлу.csv')

# Зразок даних для уявлення
data = pd.DataFrame({
    'Year': [2000, 2005, 2010, 2015, 2020],
    'Ukraine': [10, 8, 6, 4, 2],  # Замініть це реальними даними для України
    'USA': [5, 4, 3, 2, 1]         # Замініть це реальними даними для США
})

# Побудова графіка
plt.figure(figsize=(10, 5))

# 2.1 Графік для динаміки показника для двох країн
plt.plot(data['Year'], data['Ukraine'], label='Ukraine')
plt.plot(data['Year'], data['USA'], label='USA')

plt.xlabel('Year')
plt.ylabel('Indicator Value')
plt.title('Dynamics of Children out of school, primary')

plt.legend()
plt.show()

# 2.2 Стовпчасті діаграми для кожної з країн
country_to_plot = input('Введіть країну для побудови діаграми (Ukraine або USA): ')

if country_to_plot in data.columns:
    plt.figure(figsize=(7, 5))
    plt.bar(data['Year'], data[country_to_plot], color='skyblue')
    plt.xlabel('Year')
    plt.ylabel('Indicator Value')
    plt.title(f'{country_to_plot} - Children out of school, primary')

    plt.show()
else:
    print('Невірна назва країни. Введіть "Ukraine" або "USA".')
