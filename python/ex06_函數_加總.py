def 加總():
    z=[1,2,3]

    t=0
    for x in z: #這邊z會有三次，因為有三個數
        print(x)
        t+=x
        print(f"t最結果{t}")

加總()