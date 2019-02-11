def balancedSum(n,arr):
    rSum = 0
    lSum = 0
    for item in arr:
        rSum += item
    
    for i in range(0,n):
        rSum -= arr[i]
        if(rSum == lSum):
            return 'YES'
        lSum += arr[i]
    return 'NO'
    


T = int(input())
for i in range(0,T):
    n = int(input())    
    arr = list(map(int,str.strip(input()).split(' ')))
    print(balancedSum(n,arr))

