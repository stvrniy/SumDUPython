import csv
import json
import os


json_filename = 'data.json'
csv_filename = 'data.csv'


try:
    with open(json_filename, mode='r', encoding='utf-8') as file:
        data = json.load(file)

    with open(csv_filename, mode='w', newline='', encoding='utf-8') as file:
        csv_writer = csv.writer(file)
        csv_writer.writerow(["Name", "Age", "City"]) 
        for row in data:
            csv_writer.writerow([row["Name"], row["Age"], row["City"]])

   
        csv_writer.writerow(["Koval", 28, "Kharkiv"])
        csv_writer.writerow(["Shevchenko", 35, "Dnipro"])
except IOError as e:
    print(f"Помилка при роботі з файлом: {e}")
