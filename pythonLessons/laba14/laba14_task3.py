import matplotlib.pyplot as plt

# Уявні дані (замініть їх реальними даними)
labels = ['Дівчата', 'Хлопці']
sizes = [60, 40]  # У відсотках

# Кольори для розфарбовування секторів
colors = ['pink', 'lightblue']

# Підписи для кожного сектору
explode = (0.1, 0)  # Виділення першого сектору (Дівчата)

# Побудова кругової діаграми
plt.figure(figsize=(6, 6))
plt.pie(sizes, explode=explode, labels=labels, colors=colors, autopct='%1.1f%%', startangle=140)

plt.title('Розподіл студентів за статтю')

plt.show()
