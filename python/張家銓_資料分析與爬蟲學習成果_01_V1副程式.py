import json

a='data01.json'
b='data01.csv'
data = []

#要輸入json的值
x = '{ "title":"鯉魚潭水庫開發史特展", "showUnit":"客家文化中心", "startDate":"2024/01/01","endDate":"2024/06/30"}'
y = '{ "title":"體感大冒險特展", "showUnit":"北藝創意股份公司", "startDate":"2024/03/01","endDate":"2024/09/30"}'

def 寫入json():
    f=open(a, 'w', encoding='UTF-8')
    s=f'[{x},{y}]\n'
    f.write(s)
    f.close()


def json轉字典_並global存入data():
    global data
    f = open(a, 'r', encoding='UTF-8')
    content = f.read()
    f.close()
    data = json.loads(content)


def 鍵變字串_額外刷新覆蓋():
    keys_as_string = ','.join(data[0].keys())
    print(keys_as_string)
    f=open(b, 'w', encoding='UTF-8')
    f.write(f'{keys_as_string}\n')
    f.close()


def 值變字串():
 for item in data:
    values_as_string = ', '.join(item.values())
    print(values_as_string)
    f = open(b, 'a', encoding='UTF-8')
    f.write(f'{values_as_string}\n')
    f.close()
