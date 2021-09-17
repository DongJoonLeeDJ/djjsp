import numpy as np
from sklearn.neighbors import KNeighborsClassifier
from sklearn.ensemble import GradientBoostingClassifier
import cv2

blue = 0
green = 1
red = 2
def get_chars(image, color):
    other1 = (color + 1) % 3    # 2
    other2 = (color + 2) % 3    # 0  -> green 1 other1 =red= 2 other2 =blue= 0
    bc = image[:, :, other1] == 255
    image[bc] = [0, 0, 0]
    bc = image[:, :, other2] == 255
    image[bc] = [0, 0, 0]
    bc = image[:, :, color] < 170
    image[bc] = [0, 0, 0]
    bc = image[:, :, color] != 0
    image[bc] = [255, 255, 255]
    return image

def getwantimage(filename):
    chars = []
    colors = [blue, green, red]
    for color in colors:    # 3번 도는 for
        image = cv2.imread(filename, cv2.IMREAD_COLOR)
        color_image = get_chars(image.copy(),color)
        gray_image = cv2.cvtColor(color_image, cv2.COLOR_BGR2GRAY)
        ret, thresh_image = cv2.threshold(gray_image, 127, 255, 0)
        coutours, _ = cv2.findContours(thresh_image, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

        for cnt in coutours:
            area = cv2.contourArea(cnt)
            if area > 50:
                x, y, w, h = cv2.boundingRect(cnt)
                roi = thresh_image[y:y + h, x:x + w]
                roi20 = cv2.resize(roi,(20,20))
                chars.append((x,roi20))
    chars = sorted(chars,key=lambda char:char[0])
    return chars

def getresult(urliamge):
    train = np.load('traintarget.npz')['train']
    target = np.load('traintarget.npz')['target']
    # print(train.shape)
    # print(target.shape)

    knclf = GradientBoostingClassifier()
    knclf.fit(train,target)

    # prvalue = knclf.predict([train[0],train[1],train[2],train[3],train[4]])
    # print(prvalue)

    # 794 x 520
    wprewant = getwantimage(urliamge)
    wantEval = []
    for char in wprewant:
        data = np.array(char[1],dtype=np.float32)
        # print(data.shape) #20x20
        prevalue = knclf.predict(data.reshape(-1,400))
        # print(prevalue)
        wantEval.append(prevalue)

    result = ''
    for s in wantEval:
        if int(s[0]) > -1 and int(s[0])<10:
            result = result + str(s[0])
        if int(s[0]) == 10:
            result = result + str('+')
        if int(s[0]) == 11:
            result = result + str('-')
        if int(s[0]) == 12:
            result = result + str('*')

    temp = []
    yon=''

    for mychar in result:
        if mychar == '+' or mychar == '-' or mychar == '*':
            yon = mychar

    revalue = result.split(yon)
    evalvalue = str(int(revalue[0]))+yon+str(int(revalue[1]))

    return eval(evalvalue)