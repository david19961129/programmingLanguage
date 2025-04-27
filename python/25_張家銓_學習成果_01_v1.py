
a = float(input("請輸入第一個數字:"))
b = float(input("請輸入第二個數字:"))
c = float(input("請輸入第三個數字:"))
d = float(input("請輸入第四個數字:"))

A=f'{a:5.2f}'
B=f'{b:5.2f}'
C=f'{c:5.2f}'
D=f'{d:5.2f}'

print(f"|{A:>8}{B:>8}|")
print(f"|{C:>8}{D:>8}|")

A=f'{a:.2f}'
B=f'{b:.2f}'
C=f'{c:.2f}'
D=f'{d:.2f}'

print(f"|{A:<8} {B:<8}|")
print(f"|{C:<8} {D:<8}|")



