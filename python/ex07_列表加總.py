
z=[1,2,3]
t=z[0]+z[1]+z[2]
t=z[0]+z[-1]
print(t)

print("-----------------------------------")
z=[1,2,3]
t=0
for x in z:
    print(x)
    t+=x
    print(f"t最結果{t}")
