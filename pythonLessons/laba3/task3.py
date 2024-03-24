def find_unique_words(sentence):
    # Розбиваємо речення на слова
    words = sentence.split()

    # Лічильник кількості входжень кожного слова
    word_count = {}

    # Заповнюємо лічильник
    for word in words:
        word = word.lower()  # Перетворюємо на нижній регістр для врахування регістру
        if word in word_count:
            word_count[word] += 1
        else:
            word_count[word] = 1

    # Виводимо слова, які зустрілися лише один раз
    unique_words = [word for word, count in word_count.items() if count == 1]
    print("Слова, які зустрічаються один раз:", unique_words)

# Приклад використання
user_sentence = input("Введіть речення: ")
find_unique_words(user_sentence)
