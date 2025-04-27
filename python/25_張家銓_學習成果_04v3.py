from idlelib.autoexpand import AutoExpand

a = (input("請輸入第一個數字:"))
b = (input("請輸入第二個數字:"))
c = (input("請輸入第三個數字:"))
d = (input("請輸入第四個數字:"))
e = (input("請輸入第五個數字:"))

abc_to_123 = {'A': 1, 'B': 2, 'C': 3, 'D': 4, 'E': 5,
              'F': 6, 'G': 7, 'H': 8, 'I': 9, 'J': 10,}

if a in abc_to_123:
    v = abc_to_123[a]
    a = v
    int(a)

if b in abc_to_123:
    v = abc_to_123[b]
    b = v
    int(b)

if c in abc_to_123:
    v = abc_to_123[c]
    c = v
    int(c)

if d in abc_to_123:
    v = abc_to_123[d]
    d = v
    int(d)

if e in abc_to_123:
    v = abc_to_123[e]
    e = v
    int(e)


z=int(a)+int(b)+int(c)+int(d)+int(e)
print(f"加總結果{z}")

B = max(a, b, c, d, e)
C = min(a, b, c, d, e)

print(f"目前最小值: {C}")
print(f"目前最大值: {B}")






