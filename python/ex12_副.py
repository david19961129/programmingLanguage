x=20
y=30
z='+'
r=0

def aaa():
    global r
    r=x+y

def bbb():
    global r
    r=x-y

d={'x':aaa,'-':bbb}