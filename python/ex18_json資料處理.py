d = {}

k="0912"
v="tom"
d[k]=v

print(d)

ik=input('輸入key查詢:')
if ik in d:
    print('key 不存在')
print('---------------------------')
import json

x='{"name":"john","age":30,"city":"New York"}'

d=json.loads(x)
print(d)
print('訪問字典 取資料')
print(d["name"])
print(d["age"])

print('所有 key')
print(d.keys())

print('所有 value')
print(d.values())