def swap_case(s):
    returnable = ''
    for c in s:
        if c.isupper():
            returnable += c.lower()
        else:
            returnable += c.upper()

    return returnable

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)