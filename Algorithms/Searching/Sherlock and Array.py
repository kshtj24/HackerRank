def balancedSum(n,arr):
    arr_diff = arr[0]
    for i in range(1,n):
        arr_diff -= arr[i]    
    
    if(binary_search(arr,abs(arr_diff),0,n-1) == None):        
        return 'NO'
    else:
        return 'YES'
    
def binary_search(arr,key,L,R):
    if R >= L:
        mid = int(L + (R - L)/2)
        if arr[mid] == key:            
            return mid
        elif key < arr[mid]:
            return binary_search(arr,key,L,mid-1)
        elif key > arr[mid]:
            return binary_search(arr,key,mid+1,R)
        else:
            return -1

T = int(input())
for i in range(0,T):
    n = int(input())    
    arr = list(map(int,input().split(' ')))
    print(balancedSum(n,(sorted(arr))[::-1]))