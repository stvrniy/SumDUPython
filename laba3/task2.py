def remove_non_alpha_characters(word):
    alpha_characters = [char for char in word if char.isalpha()]
    new_word = ''.join(alpha_characters)
    return new_word


input_word = "Input123 word!"
new_word = remove_non_alpha_characters(input_word)

print(f"Input word: {input_word}")
print(f"New word without non-alphabetic characters: {new_word}")
