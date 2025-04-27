import ex13_Q1
d={'1':ex13_Q1.run_q1}

k=input('輸入題號:')
if k in d.keys():
    d[k]()
else:
    print('題號不存在')