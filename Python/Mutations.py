def mutate_string(string, position, character):
    lst = list(string)
    lst[position] = character
    return ''.join(lst)