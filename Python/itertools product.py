from itertools import product

print(*list(product(list(map(int,input().split(' '))),list(map(int,input().split(' '))))),sep=' ')