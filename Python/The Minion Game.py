def minion_game(string):
    kevin = 0;
    stuart = 0;
    vowels = 'AEIOU'
    
    for i in range(0,len(string)):
        if vowels.count(string[i]) > 0:
            kevin = kevin + (len(string) - i)
        else:
            stuart = stuart + (len(string) - i)
    
    result = ('Kevin '+ str(kevin)) if kevin > stuart else ('Stuart '+ str(stuart))

    if kevin == stuart:
        print('Draw')
    else:
        print(result)


if __name__ == '__main__':
    s = input()
    minion_game(s)