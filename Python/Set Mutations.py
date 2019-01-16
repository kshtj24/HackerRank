n = int(input())
aSet = set(map(int,input().split(' ')))
count = int(input())

for _ in range(0,count):
    command = input().split(' ')
    uSet = set(map(int,input().split(' ')))
    eval('aSet.' + command[0] + '(uSet)')

print(sum(aSet))