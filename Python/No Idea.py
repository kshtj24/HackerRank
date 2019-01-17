n,m = map(int,input().split(' '))
arr = list(map(int,input().split(' ')))
A = set(map(int,input().split(' ')))
B = set(map(int,input().split(' ')))

happiness = 0

for i in arr:
    if A.__contains__(i):
        happiness = happiness + 1
    elif B.__contains__(i):
        happiness = happiness - 1

print(happiness)
