#!/bin/python3


import os
import math
# Complete the hackerlandRadioTransmitters function below.
def hackerlandRadioTransmitters(x, k):
    num = max(x)
    a = num/(k*2)
    if(a%1 == 0.5):
        res = math.ceil(a)
    else:
        res = round(a)

    return int(res)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    x = list(map(int, input().rstrip().split()))

    result = hackerlandRadioTransmitters(x, k)

    fptr.write(str(result) + '\n')

    fptr.close()
