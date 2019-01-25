from itertools import combinations

mInput = input().split(' ')
count = 0
lst = list()
while count < (int(mInput[1]) + 1):
    lst = lst + list(combinations(sorted(mInput[0]),count))
    count = count + 1

for i in range(1,len(lst)):    
    print(*lst[i],sep='')
