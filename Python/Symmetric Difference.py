m = input()
M = set(map(int,input().split(' ')))
n = input()
N = set(map(int,input().split(' ')))

l = list(M.difference(N)) + list(N.difference(M))

l.sort()

for item in l:
    print(item)