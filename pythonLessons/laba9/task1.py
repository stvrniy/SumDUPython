def create_and_write_to_file(file_path):
    try:
        with open(file_path, 'w') as file:
            file.write("Hello, world!\nThis is a sample text file.\nWith multiple lines of varying lengths.\n")
            file.write("Words in this file are separated by spaces and punctuation marks.\n")
            file.write("This is an example file for TF16_1.")
        print(f"Файл {file_path} успішно створено та заповнено текстом.")
    except IOError as e:
        print(f"Помилка відкриття/запису файлу: {e}")

def find_and_write_words_starting_with_vowel(input_file, output_file):
    try:
        with open(input_file, 'r') as input_file, open(output_file, 'w') as output_file:
            for line in input_file:
                words = line.split()
                for word in words:
                    if word and word[0].lower() in 'aeiou':
                        output_file.write(word + '\n')
        print(f"Слова, що починаються з голосної літери, записані у файл {output_file.name}.")
    except IOError as e:
        print(f"Помилка відкриття/запису файлу: {e}")

def read_and_print_file(file_path):
    try:
        with open(file_path, 'r') as file:
            print(f"Вміст файлу {file_path}:")
            for line in file:
                print(line.strip())
    except IOError as e:
        print(f"Помилка відкриття/читання файлу: {e}")

# Ініціалізація файлових шляхів
file_path_1 = "TF16_1.txt"
file_path_2 = "TF16_2.txt"

# Створення та запис даних у файл TF16_1
create_and_write_to_file(file_path_1)

# Знайдення та запис слів, які починаються з голосної літери, у файл TF16_2
find_and_write_words_starting_with_vowel(file_path_1, file_path_2)

# Читання та вивід вмісту файлу TF16_2
read_and_print_file(file_path_2)
