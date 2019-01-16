e = int(input())
eSet = set(map(int,input().split(' ')))
f = int(input())
fSet = set(map(int,input().split(' ')))

print((len(eSet.union(fSet))))