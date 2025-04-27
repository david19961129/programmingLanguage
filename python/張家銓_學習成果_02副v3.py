x=10
y=20
r=0

def aaa():
    global r
    r=x+y

def bbb():
    global r
    r=x-y

def ccc():
    global r
    r=x*y

def ddd():
    global r
    r=x/y

def eee():
    global r
    r=x//y

def fff():
    global r
    r=x%y

d={'+':aaa,'-':bbb,'*':ccc,'/':ddd,'//':eee,'%':fff}