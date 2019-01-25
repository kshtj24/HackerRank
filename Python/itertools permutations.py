from itertools import permutations
mInput = input().split(' ')
lst = list(permutations(mInput[0], int(mInput[1])))
for element in sorted(lst):
    print(*element,sep='')